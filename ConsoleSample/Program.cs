using F1Sharp;
using F1Sharp.Data;
using F1Sharp.Packets;
using F1Sharp.ViewModels;
using System;
using System.Runtime.InteropServices;

namespace ConsoleSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Listening for F1 23...");

            TelemetryClient client = new(20777);

            // client.OnCarDamageDataReceive += Client_OnCarDamageDataReceive;
            client.OnLapDataReceive += Client_OnLapDataRecieve;
            //   client.OnMotionDataReceive += Client_OnMotionDataReceive;
            //client.OnCarTelemetryDataReceive += Client_OnCarTelemtryRecieve;
             Console.CursorVisible = false;
            Console.Read();
        }

        private static void Client_OnCarTelemtryRecieve(CarTelemetryPacket carTelemetryPacket)
        {
            Console.Clear();
            CarTelemetryData carTelemetryData = carTelemetryPacket.carTelemetryData.ElementAt<CarTelemetryData>(carTelemetryPacket.header.playerCarIndex);
            Console.WriteLine($"Speed\t\t{carTelemetryData.speed}");
            Console.WriteLine($"Throttle\t\t{carTelemetryData.throttle}");
            Console.WriteLine($"Steer\t\t{carTelemetryData.steer}");
            Console.WriteLine($"Brake\t\t{carTelemetryData.brake}");
            Console.WriteLine($"Clutch\t\t{carTelemetryData.clutch}");
            Console.WriteLine($"Gear\t\t{carTelemetryData.gear}");
            Console.WriteLine($"Suggested Gear\t\t{carTelemetryPacket.suggestedGear}");
            Console.WriteLine($"Engine RPM\t\t{carTelemetryData.engineRPM}");
            Console.WriteLine($"DRS\t\t{carTelemetryData.drs}");
            Console.WriteLine($"Rev Light %\t\t{carTelemetryData.revLightsPercent}");
            Console.WriteLine($"Rev Light Bit Value\t\t{carTelemetryData.revLightsBitValue}");
            Console.WriteLine($"Brake RL Temp\t\t{carTelemetryData.brakesTemperature[0]}");
            Console.WriteLine($"Brake RR Temp\t\t{carTelemetryData.brakesTemperature[1]}");
            Console.WriteLine($"Brake RL Temp\t\t{carTelemetryData.brakesTemperature[2]}");
            Console.WriteLine($"Brake FR Temp\t\t{carTelemetryData.brakesTemperature[3]}");
            Console.WriteLine($"Tyre RL Surface Temp\t\t{carTelemetryData.tyresSurfaceTemperature[0]}");
            Console.WriteLine($"Tyre RR Surface Temp\t\t{carTelemetryData.tyresSurfaceTemperature[1]}");
            Console.WriteLine($"Tyre FL Surface Temp\t\t{carTelemetryData.tyresSurfaceTemperature[2]}");
            Console.WriteLine($"Tyre FR Surface Temp\t\t{carTelemetryData.tyresSurfaceTemperature[3]}");
            Console.WriteLine($"Tyre RL Inner Temp\t\t{carTelemetryData.tyresInnerTemperature[0]}");
            Console.WriteLine($"Tyre RR Inner Temp\t\t{carTelemetryData.tyresInnerTemperature[1]}");
            Console.WriteLine($"Tyre FL Inner Temp\t\t{carTelemetryData.tyresInnerTemperature[2]}");
            Console.WriteLine($"Tyre FR Innner Temp\t\t{carTelemetryData.tyresInnerTemperature[3]}");
            Console.WriteLine($"Engine Temp\t\t{carTelemetryData.engineTemperature}");
            Console.WriteLine($"Tyre RL PSI\t\t{carTelemetryData.tyresInnerTemperature[0]}");
            Console.WriteLine($"Tyre RR PSI\t\t{carTelemetryData.tyresInnerTemperature[1]}");
            Console.WriteLine($"Tyre FL PSI\t\t{carTelemetryData.tyresInnerTemperature[2]}");
            Console.WriteLine($"Tyre FR PSI\t\t{carTelemetryData.tyresInnerTemperature[3]}");
            Console.WriteLine($"Tyre RL Surfacte Type\t\t{carTelemetryData.surfaceType[0]}");
            Console.WriteLine($"Tyre RR Surfacte Type\t\t{carTelemetryData.surfaceType[1]}");
            Console.WriteLine($"Tyre FL Surfacte Type\t\t{carTelemetryData.surfaceType[2]}");
            Console.WriteLine($"Tyre FR Surfacte Type\t\t{carTelemetryData.surfaceType[3]}");
        }

        private static void Client_OnMotionDataReceive(MotionPacket motionPacket)
        {

            Console.Clear();
    

        }

        private static void Client_OnLapDataRecieve(LapDataPacket lapPacket)
        {

            Console.Clear();
            F1Sharp.Data.LapData lapData = lapPacket.lapData.ElementAt<F1Sharp.Data.LapData>(lapPacket.header.playerCarIndex);
            Console.WriteLine($"Last Lap Time\t\t{lapData.lastLapTimeInMS}");
            Console.WriteLine($"Current Lap Time\t\t{lapData.currentLapTimeInMS}");
            Console.WriteLine($"Sector 1 Time\t\t{lapData.sector1TimeMinutes}:{lapData.sector1TimeInMS}");
            Console.WriteLine($"Sector 2 Time\t\t{lapData.sector2TimeMinutes}:{lapData.sector2TimeInMS}");
            Console.WriteLine($"Delta to car in Front\t\t{lapData.deltaToCarInFrontInMS}");
            Console.WriteLine($"Delta to Race Leader\t\t{lapData.deltaToRaceLeaderInMS}");
            Console.WriteLine($"Lap Distance\t\t{lapData.lapDistance}");
            Console.WriteLine($"Total Distance\t\t{lapData.totalDistance}");
            Console.WriteLine($"Safety Car Delta\t\t{lapData.safetyCarDelta}");
            Console.WriteLine($"Car Race Position\t\t{lapData.carPosition}");
            Console.WriteLine($"Current Lap Number\t\t{lapData.currentLapNum}");
            Console.WriteLine($"Pit status\t\t{lapData.pitStatus}");
            Console.WriteLine($"Number of Pit Stops\t\t{lapData.numPitStops}");
            Console.WriteLine($"Secotr\t\t{lapData.sector}");
            Console.WriteLine($"Current lap is invalid\t\t{lapData.currentLapInvalid}");
            Console.WriteLine($"Penalties\t\t{lapData.penalties}");
            Console.WriteLine($"Warnings\t\t{lapData.totalWarnings}");
            Console.WriteLine($"Corner Cutting Warnings\t\t{lapData.totalWarnings}");
            Console.WriteLine($"Underserved Drive Through Penalties\t\t{lapData.numUnservedDriveThroughPens}");
            Console.WriteLine($"Underserved Stop Go Penalties\t\t{lapData.numUnservedStopGoPens}");
            Console.WriteLine($"Grid Position\t\t{lapData.gridPosition}");
            Console.WriteLine($"Driver Status\t\t{lapData.driverStatus}");
            Console.WriteLine($"Result Status\t\t{lapData.resultStatus}");
            Console.WriteLine($"Pit Lane Time Active\t\t{lapData.pitLaneTimerActive}");
            Console.WriteLine($"Time Spent in Pitlane\t\t{lapData.pitLaneTimeInLaneInMS}");
            Console.WriteLine($"Pit stop time\t\t{lapData.pitStopTimerInMS}");
            Console.WriteLine($"Server Penalty on Stop\t\t{lapData.pitStopShouldServePen}");

            //Console.WriteLine("Index\tLap\tSector 1\tSector 2\tSector 3");
            //foreach (LapData in lapPacket.lapData)
            //{
            //    Console.Write($"{index}\t");
            //    Console.Write($"{lapdata.currentLapNum}\t");
            //    Console.Write($"{lapdata.sector1TimeInMS}\t");
            //    Console.Write($"{lapdata.sector2TimeInMS}\t");
            //    Console.Write($"0\t\n");
            //}
        }

        private static void Client_OnCarDamageDataReceive(CarDamagePacket packet)
        {
            int index = 0;
            Console.Clear();
            foreach (CarDamageData data in packet.carDamageData)
            {
                Console.WriteLine($"INDEX: {index}");
                Console.WriteLine($"{data}");
                Console.WriteLine("----");
                index++;
                if (index == 5)
                {
                    break;
                }
            }

            Console.WriteLine($"{packet.carDamageData[packet.header.playerCarIndex]}");
        }
    }
}