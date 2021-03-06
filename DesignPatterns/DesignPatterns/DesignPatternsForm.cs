﻿using FacadePattern;
using ObserverPattern;
using ProxyPattern;
using System;
using System.Windows.Forms;

namespace DesignPatterns
{
    public partial class DesignPatternsForm : Form
    {
        public DesignPatternsForm()
        {
            InitializeComponent();
        }

        private void AdapterPatternBtn_Click(object sender, EventArgs e)
        {
            AdapterPattern.Client.Main();
        }

        private void ObserverPatternBtn_Click(object sender, EventArgs e)
        {
            Form observerForm = new ObserverForm();
            observerForm.Show();
        }

        private void DecoratorPatternBtn_Click(object sender, EventArgs e)
        {
            DecoratorPattern.Client.Main();
        }

        private void FacadePatternBtn_Click(object sender, EventArgs e)
        {
            Form facadeForm = new FacadeForm();
            facadeForm.Show();
        }

        private void ProxyPatternBtn_Click(object sender, EventArgs e)
        {
            Form proxyPattern = new ProxyForm();
            proxyPattern.Show();
        }

        private void CompositePatternBtn_Click(object sender, EventArgs e)
        {
            CompositePattern.Client.Main();
        }

        private void SingletonPatternBtn_Click(object sender, EventArgs e)
        {
            SingletonPattern.Client.Main();
        }

        private void IteratorPatternBtn_Click(object sender, EventArgs e)
        {
            IteratorPattern.Client.Main();
        }

        private void FlyweightPatternBtn_Click(object sender, EventArgs e)
        {
            FlyweightPattern.Client.Main();
        }
    }
}
