using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XenoRPGEditor
{
	class FilterList<T> : BindingList<T>, IBindingListView, IRaiseItemChangedEvents
	{
		// Put original list in here so after filtering we can get it back
		private List<T> _originalList = new List<T>();

		private string _strFilter = null;
		private bool   _isFiltered = false;
		private bool   _isSorted = false;

		private ListSortDirection _sortDirection = ListSortDirection.Ascending;
		private PropertyDescriptor _sortProperty = null;
		private ListSortDescriptionCollection _sortDescriptions = new ListSortDescriptionCollection();

		public string Filter
		{
			get
			{
				return _strFilter;
			}

			set
			{
				_strFilter = value;
				_isFiltered = true;

				UpdateFilter();
			}
		}

		ListSortDescriptionCollection IBindingListView.SortDescriptions
		{
			get
			{
				return _sortDescriptions;
			}
		}

		bool IBindingListView.SupportsAdvancedSorting
		{
			get
			{
				return true;
			}
		}

		bool IBindingListView.SupportsFiltering
		{
			get
			{
				return true;
			}
		}


		// ctor
		public FilterList() : base()
		{
			;
		}


		// ctor
		public FilterList( List<T> newList ) : base( newList )
		{
			; // Nothing else yet
		}


		protected virtual void UpdateFilter()
		{
			int equalsPos = _strFilter.IndexOf( '=' );

			// Get property name
			string propName = _strFilter.Substring( 0, equalsPos ).Trim();

			// Get filter criteria
			string criteria = _strFilter.Substring( equalsPos + 1, _strFilter.Length - equalsPos - 1 ).Trim();

			// Strip leading and trailing quotes
			criteria = criteria.Substring( 1, criteria.Length - 2 );

			// Get a property descriptor for the filter property
			PropertyDescriptor propDesc = TypeDescriptor.GetProperties( typeof( T ) )[ propName ];

			// Save list...
			if ( _originalList.Count == 0 ) _originalList.AddRange( this );

			// Rebuild current list with filter criteria...
			var listCurrent = new List<T>( this );
			Clear();
			foreach ( T item in listCurrent )
			{
				object value = propDesc.GetValue( item );
				if ( value.ToString() == criteria ) this.Add( item );
			}
		}


		void IBindingListView.RemoveFilter()
		{
			if ( !_isFiltered ) return;

			_isFiltered = false;
			_strFilter = null;

			Clear();
			foreach (T item in _originalList) this.Add( item );

			_originalList.Clear();
		}


		private void ApplySortInternal(SortComparer<T> comparer)
		{
			if ( _originalList.Count == 0 )
			{
				_originalList.AddRange( this );
			}

			List<T> listRef = this.Items as List<T>;
			if ( listRef == null ) return;

			listRef.Sort( comparer );
			_isSorted = true;
			OnListChanged( new ListChangedEventArgs(
			ListChangedType.Reset, -1 ) );
		}

		void IBindingListView.ApplySort( ListSortDescriptionCollection sorts )
		{
			_sortProperty = null;
			_sortDescriptions = sorts;
			SortComparer<T> comparer = new SortComparer<T>( sorts );
			ApplySortInternal( comparer );
		}

		bool IBindingList.AllowNew {
			get {
				return CheckReadOnly();
			}
		}

		bool IBindingList.AllowRemove {
			get {
				return CheckReadOnly();
			}
		}


		private bool CheckReadOnly()
		{
			return !_isSorted && !_isFiltered;
		}


		protected override void InsertItem( int index, T item )
		{
			foreach ( PropertyDescriptor propDesc in
			   TypeDescriptor.GetProperties( item ) )
			{
				if ( propDesc.SupportsChangeEvents )
				{
					propDesc.AddValueChanged( item, OnItemChanged );
				}
			}
			base.InsertItem( index, item );
		}


		protected override void RemoveItem( int index )
		{
			T item = Items[ index ];
			PropertyDescriptorCollection propDescs = TypeDescriptor.GetProperties( item );
			foreach ( PropertyDescriptor propDesc in propDescs )
			{
				if ( propDesc.SupportsChangeEvents )
				{
					propDesc.RemoveValueChanged( item, OnItemChanged );
				}
			}
			base.RemoveItem( index );
		}


		void OnItemChanged( object sender, EventArgs args )
		{
			int index = Items.IndexOf( ( T )sender );
			OnListChanged( new ListChangedEventArgs(
			  ListChangedType.ItemChanged, index ) );
		}


		bool IRaiseItemChangedEvents.RaisesItemChangedEvents
		{
			get { return true; }
		}

	}

/*
	public class BindingListView<T> : BindingList<T>, IBindingListView, IRaiseItemChangedEvents
	{
		private bool m_Sorted = false;
		private bool m_Filtered = false;
		private string _strFilter = null;
		private ListSortDirection m_SortDirection = ListSortDirection.Ascending;
		private PropertyDescriptor m_SortProperty = null;
		private ListSortDescriptionCollection m_SortDescriptions = new ListSortDescriptionCollection();
		private List<T> _originalList = new List<T>();

		public BindingListView()
			: base() {
		}

		public BindingListView(List<T> list)
			: base(list) {
		}

		private void ApplySortInternal(SortComparer<T> comparer)
		{
			if ( _originalList.Count == 0 )
			{
				_originalList.AddRange( this );
			}
			List<T> listRef = this.Items as List<T>;
			if ( listRef == null )
				return;
			listRef.Sort( comparer );
			m_Sorted = true;
			OnListChanged( new ListChangedEventArgs(
			ListChangedType.Reset, -1 ) );
		}

		void IBindingListView.ApplySort(ListSortDescriptionCollection sorts) {
			m_SortProperty = null;
			m_SortDescriptions = sorts;
			SortComparer<T> comparer = new SortComparer<T>(sorts);
			ApplySortInternal(comparer);
		}

		string IBindingListView.Filter {
			get {
				return _strFilter;
			}
			set {
				_strFilter = value;
				m_Filtered = true;
				UpdateFilter();
			}
		}

		void IBindingListView.RemoveFilter()
		{
			if (!m_Filtered)
				return;
			_strFilter = null;
			m_Filtered = false;
			m_Sorted = false;
			m_SortDescriptions = null;
			m_SortProperty = null;
			Clear();
			foreach (T item in _originalList) {
				Add(item);
			}
			_originalList.Clear();
		}
		ListSortDescriptionCollection IBindingListView.SortDescriptions {
			get {
				return m_SortDescriptions;
			}
		}

		bool IBindingListView.SupportsAdvancedSorting {
			get {
				return true;
			}
		}

		bool IBindingListView.SupportsFiltering {
			get {
				return true;
			}
		}

		protected virtual void UpdateFilter() {
			int equalsPos = _strFilter.IndexOf('=');
			// Get property name
			string propName = _strFilter.Substring(0, equalsPos).Trim();
			// Get filter criteria
			string criteria = _strFilter.Substring(equalsPos + 1,
			   _strFilter.Length - equalsPos - 1).Trim();
			// Strip leading and trailing quotes
			criteria = criteria.Substring(1, criteria.Length - 2);
			// Get a property descriptor for the filter property
			PropertyDescriptor propDesc = TypeDescriptor.GetProperties(typeof(T))[propName];
			if (_originalList.Count == 0) {
				_originalList.AddRange(this);
			}
			List<T> currentCollection = new List<T>(this);
			Clear();
			foreach (T item in currentCollection) {
				object value = propDesc.GetValue(item);
				if (value.ToString() == criteria) {
					Add(item);
				}
			}
		}

		bool IBindingList.AllowNew {
			get {
				return CheckReadOnly();
			}
		}

		bool IBindingList.AllowRemove {
			get {
				return CheckReadOnly();
			}
		}

		private bool CheckReadOnly() {
			if (m_Sorted || m_Filtered) {
				return false;
			} else {
				return true;
			}
		}

		protected override void InsertItem(int index, T item) {
			foreach (PropertyDescriptor propDesc in
			   TypeDescriptor.GetProperties(item)) {
				if (propDesc.SupportsChangeEvents) {
					propDesc.AddValueChanged(item, OnItemChanged);
				}
			}
			base.InsertItem(index, item);
		}

		protected override void RemoveItem(int index) {
			T item = Items[index];
			PropertyDescriptorCollection propDescs = TypeDescriptor.GetProperties(item);
			foreach (PropertyDescriptor propDesc in propDescs) {
				if (propDesc.SupportsChangeEvents) {
					propDesc.RemoveValueChanged(item, OnItemChanged);
				}
			}
			base.RemoveItem(index);
		}

		void OnItemChanged(object sender, EventArgs args) {
			int index = Items.IndexOf((T)sender);
			OnListChanged(new ListChangedEventArgs(
			  ListChangedType.ItemChanged, index));
		}

		bool IRaiseItemChangedEvents.RaisesItemChangedEvents {
			get { return true; }
		}
	}
*/
	class SortComparer<T> : IComparer<T>
	{
		private ListSortDescriptionCollection m_SortCollection = null;
		private PropertyDescriptor m_PropDesc = null;
		private ListSortDirection m_Direction =
		   ListSortDirection.Ascending;

		public SortComparer(PropertyDescriptor propDesc,
		   ListSortDirection direction) {
			m_PropDesc = propDesc;
			m_Direction = direction;
		}

		public SortComparer(ListSortDescriptionCollection sortCollection) {
			m_SortCollection = sortCollection;
		}

		int IComparer<T>.Compare(T x, T y) {
			if (m_PropDesc != null) // Simple sort
			{
				object xValue = m_PropDesc.GetValue(x);
				object yValue = m_PropDesc.GetValue(y);
				return CompareValues(xValue, yValue, m_Direction);
			} else if (m_SortCollection != null &&
				m_SortCollection.Count > 0) {
				return RecursiveCompareInternal(x, y, 0);
			} else return 0;
		}

		private int CompareValues(object xValue, object yValue,
		   ListSortDirection direction) {

			int retValue = 0;
			if (xValue is IComparable) {
				retValue = ((IComparable)xValue).CompareTo(yValue);
			} else if (yValue is IComparable) {
				retValue = ((IComparable)yValue).CompareTo(xValue);
			}
				// not comparable, compare String representations
			else if (!xValue.Equals(yValue)) {
				retValue = xValue.ToString().CompareTo(yValue.ToString());
			}
			if (direction == ListSortDirection.Ascending) {
				return retValue;
			} else {
				return retValue * -1;
			}
		}

		private int RecursiveCompareInternal(T x, T y, int index) {
			if (index >= m_SortCollection.Count)
				return 0; // termination condition

			ListSortDescription listSortDesc = m_SortCollection[index];
			object xValue = listSortDesc.PropertyDescriptor.GetValue(x);
			object yValue = listSortDesc.PropertyDescriptor.GetValue(y);

			int retValue = CompareValues(xValue,
			   yValue, listSortDesc.SortDirection);
			if (retValue == 0) {
				return RecursiveCompareInternal(x, y, ++index);
			} else {
				return retValue;
			}
		}
	}
}
