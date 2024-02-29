﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanLyKho.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public bool Isloaded { get; set; }
        public ICommand LoadedWindowCommand { get; set; }
        public ICommand UnitCommand { get; set; }
        public ICommand SupplierCommand { get; set; }
        public ICommand CustomerCommand { get; set; }
        public ICommand ObjectCommand { get; set; } 
        public ICommand UserCommand { get; set; }

        public MainViewModel() {
            LoadedWindowCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                Isloaded = true;
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.ShowDialog();
            }
            );
            UnitCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {

                UnitWindow wd = new UnitWindow();
                wd.ShowDialog();
            }
            );

            SupplierCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {

                SupplierWindow wd = new SupplierWindow();
                wd.ShowDialog();
            }
            );

            CustomerCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {

                CustomerWindow  wd = new CustomerWindow();
                wd.ShowDialog();
            }
            );

            ObjectCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {

                ObjectWindow wd = new ObjectWindow();
                wd.ShowDialog();
            }
            );

            UserCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {

                UserWIndow wd = new UserWIndow();
                wd.ShowDialog();
            }
            );
        }
    }
}
