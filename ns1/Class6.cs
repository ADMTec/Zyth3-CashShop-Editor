namespace ns1
{
    using ns2;
    using System;
    using System.Data;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    internal class Class6
    {
        public static DataSet smethod_0(string string_0, bool bool_0)
        {
            DataSet set = new DataSet(string_0);
            set.Tables.Add(smethod_5("IBSCategory"));
            set.Tables.Add(smethod_5("IBSProduct"));
            set.Tables.Add(smethod_5("IBSPackage"));
            set.Tables.Add(smethod_5("CashShopProduct"));
            set.Tables.Add(smethod_5("CashShopPackage"));
            if (bool_0)
            {
                smethod_4(set.Tables["IBSCategory"]);
            }
            return set;
        }

        public static bool smethod_1(DataTable dataTable_0, string string_0, bool bool_0, string string_1, bool bool_1, string string_2)
        {
            try
            {
                dataTable_0.DefaultView.Sort = string_2 + " ASC";
                dataTable_0 = dataTable_0.DefaultView.ToTable();
                StreamWriter writer = new StreamWriter(string_1, false, Encoding.Default);
                if (bool_0)
                {
                    string str = "//";
                    writer.WriteLine("//|================================================================|");
                    writer.WriteLine("//| Zythe CashShop Editor Ver " + Application.ProductVersion + "                              |");
                    writer.WriteLine("//| Credit: Zyth3                               [skype:i_am_zythe] |");
                    writer.WriteLine("//|================================================================|");
                    foreach (DataColumn column in dataTable_0.Columns)
                    {
                        str = str + column.ColumnName + string_0;
                    }
                    writer.WriteLine(str.Remove(str.Length - 1, 1));
                }
                foreach (DataRow row in dataTable_0.Rows)
                {
                    string str2 = string.Empty;
                    foreach (object obj2 in row.ItemArray)
                    {
                        str2 = str2 + obj2.ToString() + string_0;
                    }
                    writer.WriteLine(str2.Remove(str2.Length - 1, 1));
                    if (bool_1)
                    {
                        writer.WriteLine("end");
                    }
                }
                writer.Flush();
                writer.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool smethod_2(DataTable dataTable_0, string[] string_0, string string_1)
        {
            bool flag = false;
            string[] strArray = string_0[1].Split(new char[] { '^' }, StringSplitOptions.RemoveEmptyEntries);
            if ((string_0[0] != string_1) || (strArray.Length <= 0))
            {
                return flag;
            }
            foreach (string str in strArray)
            {
                string[] values = str.Split(new char[] { '@' });
                if (values.Length > 0)
                {
                    dataTable_0.Rows.Add(values);
                }
            }
            return true;
        }

        public static void smethod_3(DataSet dataSet_0, string string_0, bool bool_0)
        {
            try
            {
                string str;
                StreamWriter writer = new StreamWriter(string_0, false, Encoding.Default);
                if (bool_0)
                {
                    writer.WriteLine("//|================================================================|");
                    writer.WriteLine("//| Zythe CashShop Editor Ver " + Application.ProductVersion + "                              |");
                    writer.WriteLine("//| Credit: Zyth3                               [skype:i_am_zythe] |");
                    writer.WriteLine("//|================================================================|");
                }
                writer.Write("IBSCT;");
                foreach (DataRow row in dataSet_0.Tables["IBSCategory"].Rows)
                {
                    str = string.Empty;
                    foreach (object obj2 in row.ItemArray)
                    {
                        str = str + obj2.ToString() + "@";
                    }
                    writer.Write(str.Remove(str.Length - 1, 1) + "^");
                }
                writer.WriteLine();
                writer.Write("IBSPK;");
                foreach (DataRow row in dataSet_0.Tables["IBSPackage"].Rows)
                {
                    str = string.Empty;
                    foreach (object obj2 in row.ItemArray)
                    {
                        str = str + obj2.ToString() + "@";
                    }
                    writer.Write(str.Remove(str.Length - 1, 1) + "^");
                }
                writer.WriteLine();
                writer.Write("IBSPD;");
                foreach (DataRow row in dataSet_0.Tables["IBSProduct"].Rows)
                {
                    str = string.Empty;
                    foreach (object obj2 in row.ItemArray)
                    {
                        str = str + obj2.ToString() + "@";
                    }
                    writer.Write(str.Remove(str.Length - 1, 1) + "^");
                }
                writer.WriteLine();
                writer.Write("CSHPK;");
                foreach (DataRow row in dataSet_0.Tables["CashShopPackage"].Rows)
                {
                    str = string.Empty;
                    foreach (object obj2 in row.ItemArray)
                    {
                        str = str + obj2.ToString() + "@";
                    }
                    writer.Write(str.Remove(str.Length - 1, 1) + "^");
                }
                writer.WriteLine();
                writer.Write("CSHPD;");
                foreach (DataRow row in dataSet_0.Tables["CashShopProduct"].Rows)
                {
                    str = string.Empty;
                    foreach (object obj2 in row.ItemArray)
                    {
                        str = str + obj2.ToString() + "@";
                    }
                    writer.Write(str.Remove(str.Length - 1, 1) + "^");
                }
                writer.Flush();
                writer.Close();
            }
            catch (Exception exception)
            {
                Class3.smethod_1(exception.Message, "error");
            }
        }

        private static void smethod_4(DataTable dataTable_0)
        {
            string[] strArray2 = new string[] { "10@W Coin (C)@200@201@10@1@1", "31@Special@200@201@10@1@0", "32@Accessory@200@201@10@2@0", "34@Buff@200@201@10@3@0", "35@Pet@200@201@10@4@0", "37@Ticket@200@201@10@5@0", "11@W Coin (P)@200@201@11@2@1", "41@Special@200@201@11@1@0", "42@Accessory@200@201@11@2@0", "20@Goblin Point@200@201@20@3@1", "61@Skills@200@201@20@1@0", "62@Mix@200@201@20@2@0" };
            foreach (string str in strArray2)
            {
                string[] strArray4 = str.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);
                DataRow row = dataTable_0.NewRow();
                if (strArray4.Length > 1)
                {
                    for (int i = 0; i < strArray4.Length; i++)
                    {
                        row[i] = strArray4[i];
                    }
                    dataTable_0.Rows.Add(row);
                }
            }
        }

        private static DataTable smethod_5(string string_0)
        {
            int num;
            string[] strArray4;
            DataTable table = new DataTable(string_0);
            switch (string_0)
            {
                case null:
                    return table;

                case "IBSCategory":
                    table.Columns.Add(new DataColumn("CategoryID", typeof(int)));
                    table.Columns.Add(new DataColumn("CategoryName", typeof(string)));
                    table.Columns.Add(new DataColumn("200", typeof(int)));
                    table.Columns.Add(new DataColumn("201", typeof(int)));
                    table.Columns.Add(new DataColumn("TypeID", typeof(int)));
                    table.Columns.Add(new DataColumn("CategorySort", typeof(int)));
                    table.Columns.Add(new DataColumn("Code", typeof(int)));
                    table.PrimaryKey = new DataColumn[] { table.Columns["CategoryID"] };
                    return table;

                case "IBSProduct":
                    {
                        string[] strArray = "ProductID@Name@PackType@Count@UnitType@Price@ProductNumber@142@145@1@144@673@518@ItemID@PType1@PType2@PType3".Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);
                        for (num = 0; num < strArray.Length; num++)
                        {
                            string[] source = new string[] { "Name", "Type", "UnitType" };
                            if (source.Contains<string>(strArray[num]))
                            {
                                table.Columns.Add(new DataColumn(strArray[num], typeof(string)));
                            }
                            else
                            {
                                strArray4 = new string[] { "ProductID", "Count", "Price", "ProductNumber" };
                                if (strArray4.Contains<string>(strArray[num]))
                                {
                                    table.Columns.Add(new DataColumn(strArray[num], typeof(int)));
                                }
                                else
                                {
                                    table.Columns.Add(new DataColumn(strArray[num]));
                                }
                            }
                        }
                        return table;
                    }
                case "IBSPackage":
                    {
                        string[] strArray5 = "CategoryID@PackageSort@PackageID@Name@170@Price@Description@null@182@185@000@0000@177@1@Currency1@Currency2@181@200@0@ProductID@ItemID@CurrencyCode1@NumberOfItems@ProductNumber@CurrencyCode2@CurrencyCode3@669".Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);
                        for (num = 0; num < strArray5.Length; num++)
                        {
                            string[] strArray6 = new string[] { "Name", "Description", "Currency1", "Currency2" };
                            if (strArray6.Contains<string>(strArray5[num]))
                            {
                                table.Columns.Add(new DataColumn(strArray5[num], typeof(string)));
                            }
                            else
                            {
                                strArray4 = new string[] { "CategoryID", "PackageSort", "PackageID", "Price", "ItemID" };
                                if (strArray4.Contains<string>(strArray5[num]))
                                {
                                    table.Columns.Add(new DataColumn(strArray5[num], typeof(int)));
                                }
                                else
                                {
                                    table.Columns.Add(new DataColumn(strArray5[num]));
                                }
                            }
                        }
                        table.PrimaryKey = new DataColumn[] { table.Columns["PackageID"] };
                        return table;
                    }
                case "CashShopPackage":
                    table.Columns.Add(new DataColumn("CategoryID", typeof(int)));
                    table.Columns.Add(new DataColumn("PackageID", typeof(int)));
                    table.Columns.Add(new DataColumn("ItemGroup", typeof(int)));
                    table.Columns.Add(new DataColumn("ItemIndex", typeof(int)));
                    table.Columns.Add(new DataColumn("PurchaseType", typeof(int)));
                    table.Columns.Add(new DataColumn("Price", typeof(int)));
                    table.Columns.Add(new DataColumn("UseType", typeof(int)));
                    table.Columns.Add(new DataColumn("Gift", typeof(int)));
                    table.Columns.Add(new DataColumn("NumbeOfProductID", typeof(int)));
                    table.Columns.Add(new DataColumn("ProductID"));
                    table.Columns.Add(new DataColumn("Comment", typeof(string)));
                    table.PrimaryKey = new DataColumn[] { table.Columns["PackageID"] };
                    return table;

                case "CashShopProduct":
                    {
                        string[] strArray7 = "ProductID\tProductNumber\tItemGroup\tItemIndex\tPrice\tDurability\tUseTime 80\tLevel\tSkill\tLuck\tOption\tExOpt\tAncOp".Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                        for (num = 0; num < strArray7.Length; num++)
                        {
                            table.Columns.Add(new DataColumn(strArray7[num], typeof(int)));
                        }
                        table.Columns.Add(new DataColumn("Comment", typeof(string)));
                        break;
                    }
            }
            return table;
        }
    }
}

