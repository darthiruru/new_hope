using System;
using System.Data;

namespace new_hope
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create table
            DataTable table = new DataTable("Clients");
            DataColumn column;
            DataRow row;
            
            //Create id column
            column = new DataColumn();
            column.DataType = System.Type.GetType("Int32");
            column.ColumnName = "id";
            column.Caption = "ID";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);

            //Create name column
            column = new DataColumn();
            column.DataType = System.Type.GetType("String");
            column.ColumnName = "Surname and name";
            column.Caption = "Client's name";
            column.ReadOnly = true;
            table.Columns.Add(column);

            //Create status column
            column = new DataColumn();
            column.DataType = System.Type.GetType("String");
            column.ColumnName = "Status";
            column.Caption = "Client's status";
            column.ReadOnly = true;
            table.Columns.Add(column);

            //Create date of previous call column
            column = new DataColumn();
            column.DataType = System.Type.GetType("DateTime");
            column.ColumnName = "Previous date";
            column.Caption = "Date of previous call";
            column.ReadOnly = true;
            table.Columns.Add(column);

            //Create date of next call column
            column = new DataColumn();
            column.DataType = System.Type.GetType("DateTime");
            column.ColumnName = "Next date";
            column.Caption = "Date of next call";
            column.ReadOnly = true;
            table.Columns.Add(column);
        }
    }
}
