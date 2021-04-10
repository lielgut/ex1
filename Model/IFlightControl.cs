﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using OxyPlot;
using OxyPlot.Wpf;
using OxyPlot.Series;

namespace ex1.Model
{
    interface IFlightControl : INotifyPropertyChanged
    {
        float Speed { get; set; }
        int Timestep { get; set; }
        int NumLines { get; set; }
        bool IsReverse { get; set; }
        bool Stop { get; set; }
        PathInfo Paths { get; }
        public void start();
        public void stop();
        public void loadFeatures(string xmlPath);
        public void loadData(string csvPath);
        public void changePort(int destPort);
        public int getCurrentPort();
        public float getCurrentData(String feature);
        public bool SendCurrentData();
        public bool startClient();
        public void endClient();
        public void setThreshold(float threshold);
        public void analyzeData(String normalFlightPath, String newFlightPath, String anomalyDetPath);
        public void reset();
        public String getCorrelative(String featureName);
        public List<String> getFeaturesList();
        public List<int> getAnomaliesList(String featureName);
        public List<DataPoint> getDataPoints(String featureName);
        public List<ScatterPoint> getRecentScatterPoints(String featureName);
        public List<ScatterPoint> getRecentAnomalousPoints(String featureName);
        public Annotation getFeatureAnnotation(String featureName);
        public double getMinX(String featureName);
        public double getMaxX(String featureName);
        public double getMinY(String featureName);
        public double getMaxY(String featureName);
    }
}
