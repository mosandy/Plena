﻿using System;

namespace M4.M4v2.TradeDiary.InsertTableMenuItem
{
	public class TableSelectionChangedEventArgs : EventArgs
	{
		private int rowIndex;
		private int columnIndex;

		public TableSelectionChangedEventArgs(int columnIndex, int rowIndex)
		{
			this.rowIndex = rowIndex;
			this.columnIndex = columnIndex;
		}

		public int RowIndex
		{
			get { return this.rowIndex; }
		}

		public int ColumnIndex
		{
			get { return this.columnIndex; }
		}
	}
}
