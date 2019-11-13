using System;
using System.Collections.Generic;
using System.Text;

namespace StandardLibrary
{
    public class ClassSL
    {
        Console.WriteLine("Clase funcionando en Libreria .Net Standard");

#if MOBILE
            Android.Widget.Button btn = new Android.Widget.Button(null);
            btn.Text = "Ejemplo";
#else
            System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
#endif

    }
}
