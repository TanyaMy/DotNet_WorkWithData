using System;
using System.Reflection;

[assembly: AssemblyKeyFile(@"D:\NURE\3course\2semester\WorkWithDataOnDotNet\Labs\Lab1\KeyPair.snk")]
[assembly: AssemblyVersion("0.0.0.1")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyTitle("Car")]
[assembly: AssemblyCulture("")]


namespace Car
{
    public class CarBase
    {
        public virtual void CarInfo()
        {
            Console.WriteLine("Информация об автомобиле: ");
        }
    }
}
//https://professorweb.ru/my/csharp/assembly/level1/1_6.php
//https://stackoverflow.com/questions/6660512/how-to-get-csc-exe-path

//C:\WINDOWS\Microsoft.NET\Framework64\v4.0.30319\csc.exe
//C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.7.1 Tools\x64\gacutil.exe
//C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.7.1 Tools\x64\sn.exe
//"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.7.1 Tools\x64\gacutil.exe" /i Car.dll
//"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.7.1 Tools\x64\gacutil.exe" /u "Car, Version=0.0.6.9, Culture=neutral, PublicKeyToken=24a3b96af0a23528, processorArchitecture=MSIL"




//C:\WINDOWS\Microsoft.NET\Framework64\v4.0.30319\csc.exe /t:library /addmodule:CarBase.netmodule /out:Car.dll SportCar.cs
//C:\WINDOWS\Microsoft.NET\Framework64\v4.0.30319\csc.exe /t:module -resource:sport.txt CarBase.cs


//cd /d C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.7.1 Tools\x64
//gacutil /i D:\NURE\3course\2semester\WorkWithDataOnDotNet\Labs\Lab1\Car.dll