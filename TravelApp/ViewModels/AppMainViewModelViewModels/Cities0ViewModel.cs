﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TravelApp.Helpers;
using TravelApp.Models.TeleportWebApiModels;
using TravelApp.Services;

namespace TravelApp.ViewModels.AppMainViewModelViewModels
{
    public class Cities0ViewModel : ViewModelBase
    {
        public string DestinationtPointCountryName { get { return destinationPointCountryName; } set {Set(ref destinationPointCountryName,value); } }
        private string destinationPointCountryName;

        public string DestinationtPointCountryPopulation { get { return destinationtPointCountryPopulation; } set { Set(ref destinationtPointCountryPopulation, value); } }
        private string destinationtPointCountryPopulation;



        public ObservableCollection<TeleportCountrySalary> ObservableSalaries { get { return observableSalaries; } set { Set(ref observableSalaries, value); } }
        private ObservableCollection<TeleportCountrySalary> observableSalaries;

        private TeleportSearchedCityDistrictModel startPointCityDistrictModel;
        private TeleportSearchedCityDistrictModel destinationtPointCityDistrictModel;

        private ITeleportDistrictCountryServices iteleportDistrictCountryServices;
        private TeleportCountryInfo DestinationCountryInfo;

        public Cities0ViewModel()
        {
            int a = 0;
            startPointCityDistrictModel = CurrentTeleportSearchedCityDistrictModels.StartPointTeleportSearchedCityDistrictModel;
            destinationtPointCityDistrictModel = CurrentTeleportSearchedCityDistrictModels.DestinationPointTeleportSearchedCityDistrictModel;

            iteleportDistrictCountryServices = new TeleportDistrictCountryWebService();
            DestinationCountryInfo = iteleportDistrictCountryServices.GetTeleportCountryInfo(destinationtPointCityDistrictModel.CountryLink);

            DestinationtPointCountryName = "Country : " + DestinationCountryInfo.Name;
            DestinationtPointCountryPopulation = "Population : " + DestinationCountryInfo.Population;

            ObservableSalaries = new ObservableCollection<TeleportCountrySalary>(DestinationCountryInfo.TeleportCountrySalaries);

        }
    }
}