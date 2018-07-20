﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Resume.Models;

namespace Resume.FinalView
{
    /// <summary>
    /// Interaction logic for FinalView.xaml
    /// </summary>
    public partial class FinalView : Window
    {
        public FinalView(Person worker)
        {
            Worker = worker;
            InitializeComponent();
        }

        public Person Worker { get; set; }
    }
}