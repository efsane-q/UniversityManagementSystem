using System;
using System.Windows.Forms;

namespace UniversityManagementSystem
{
    public static class FormNavigation
    {
        public static void Open(Form current, Form next)
        {
            next.FormClosed += (s, e) =>
            {
                current.Show();
            };

            current.Hide();
            next.Show();
        }
    }
}