using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_EFCore_PointOfSaleSystem
{
    internal class center
    {
        public static string saleReceiptID;
        public static int saleReferenceNo;

        public static int employeeID;
        public static int customerID;

        public static void focusTecxbox(TextBox txt)
        {
            try
            {
                if(txt.CanFocus)
                {
                    txt.Focus();
                    txt.Select();
                    txt.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Focus Textbox", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
