﻿(*** hide ***)
#I "../../../bin/XPlot.Plotly/net45"
#r "XPlot.Plotly.dll"
open XPlot.Plotly
open System

(**
Plotly Candlestick Chart
========================
*)
(*** define-output:candle ***) 
let data =
    [
         // x,  o,  h,  l,  c   
        "Mon", 28, 45, 20, 38 
        "Tue", 38, 66, 31, 55 
        "Wed", 55, 80, 50, 77
        "Thu", 77, 77, 50, 66
        "Fri", 66, 68, 15, 22        
    ]
        
Chart.Candlestick data
(*** include-it:candle ***)

(*** define-output:XAU_USD_D1 ***) 
let ``XAU USD D1`` =
    [
                 // x,       o,       h,       l,       c   
        DateTime(2017, 12, 27), 1282.19, 1289.01, 1281.43, 1287.67
        DateTime(2017, 12, 26), 1278.35, 1283.80, 1277.22, 1282.18
        DateTime(2017, 12, 22), 1267.07, 1276.08, 1265.07, 1274.97
        DateTime(2017, 12, 21), 1266.53, 1268.99, 1263.20, 1267.05
        DateTime(2017, 12, 20), 1261.80, 1267.92, 1261.53, 1266.55
        DateTime(2017, 12, 19), 1261.54, 1265.32, 1259.34, 1261.78
        DateTime(2017, 12, 18), 1253.91, 1263.99, 1252.85, 1261.51
        DateTime(2017, 12, 15), 1253.62, 1261.88, 1253.18, 1255.20
        DateTime(2017, 12, 14), 1254.05, 1259.14, 1250.58, 1253.62
        DateTime(2017, 12, 13), 1243.58, 1256.93, 1240.36, 1254.09
        DateTime(2017, 12, 12), 1242.90, 1246.29, 1236.59, 1243.48
        DateTime(2017, 12, 11), 1248.63, 1251.59, 1240.89, 1242.91
        DateTime(2017, 12, 08), 1247.15, 1252.41, 1244.18, 1248.56
        DateTime(2017, 12, 07), 1264.03, 1264.17, 1244.06, 1247.16
        DateTime(2017, 12, 06), 1266.32, 1269.25, 1262.63, 1264.14
        DateTime(2017, 12, 05), 1276.61, 1277.06, 1261.11, 1266.24
        DateTime(2017, 12, 04), 1273.93, 1277.17, 1271.41, 1276.61
        DateTime(2017, 12, 01), 1275.00, 1289.24, 1271.72, 1280.40
        DateTime(2017, 11, 30), 1284.15, 1285.36, 1270.43, 1275.03
        DateTime(2017, 11, 29), 1294.07, 1296.75, 1282.18, 1284.16
        DateTime(2017, 11, 28), 1294.59, 1297.48, 1290.95, 1294.06
        DateTime(2017, 11, 27), 1287.47, 1299.29, 1286.80, 1294.56
    ]
        
``XAU USD D1`` |> Seq.sortBy (fun (x,_,_,_,_) -> x)
               |> Chart.Candlestick
               
(*** include-it:XAU_USD_D1 ***)