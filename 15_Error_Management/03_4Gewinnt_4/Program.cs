﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// ---------------------------------------------------------------------------
/// Übungsserie 03
/// Thema: Mehrdimensionale Arrays
/// Author: Silvan Gehrig
/// Version: 1.0
/// -------------------------------------------------------------------- 2022 -
/// </summary>
namespace Bwz.Rappi
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmConnectFour());
        }
    }
}
