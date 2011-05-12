using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Unit_Converter
{
    public class ConvertUnits
    {
        enum States
        {
            Start, Acceleration, Angle, Area, Energy, Force, Length, Mass, Power, Temperature, Time, Velocity,
            Volume, Undefined, Cent_SqSec, Met_SqSec, Feet_SqSec, CSS_Cent_SqSec, CSS_Met_SqSec, CSS_Feet_SqSec, MSS_Cent_SqSec,
            MSS_Met_SqSec, MSS_Feet_SqSec, FSS_Cent_SqSec, FSS_Met_SqSec, FSS_Feet_SqSec, Degrees, Gradians, Radians, D_Deg,
            D_Grad, D_Rad, G_Deg, G_Grad, G_Rad, R_Deg, R_Grad, R_Rad, Sq_Cent, Sq_Feet, Sq_Inch, Sq_Met, SC_Sq_Cent, SC_Sq_Feet,
            SC_Sq_Inch, SC_Sq_Met, SF_Sq_Cent, SF_Sq_Feet, SF_Sq_Inch, SF_Sq_Met, SI_Sq_Cent, SI_Sq_Feet, SI_Sq_Inch, SI_Sq_Met,
            SM_Sq_Cent, SM_Sq_Feet, SM_Sq_Inch, SM_Sq_Met, Btus, Calories, eV, FootPounds, Joules, KilowattHours, B_Btus, B_Calories,
            B_eV, B_FootPounds, B_Joules, B_KilowattHours, C_Btus, C_Calories, C_eV, C_FootPounds, C_Joules, C_KilowattHours,
            E_Btus, E_Calories, E_eV, E_FootPounds, E_Joules, E_KilowattHours, F_Btus, F_Calories, F_eV, F_FootPounds, F_Joules,
            F_KilowattHours, J_Btus, J_Calories, J_eV, J_FootPounds, J_Joules, J_KilowattHours, K_Btus, K_Calories, K_eV, K_FootPounds,
            K_Joules, K_KilowattHours, Newtons, Pounds, N_Newtons, N_Pounds, P_Newtons, P_Pounds, Centimeters, Feet, Inches, Kilometers,
            Meters, Miles, C_Cent, C_Feet, C_Inch, C_Kilomet, C_Met, C_Mile, F_Cent, F_Feet, F_Inch, F_Kilomet, F_Met, F_Mile, I_Cent,
            I_Feet, I_Inch, I_Kilomet, I_Met, I_Mile, K_Cent, K_Feet, K_Inch, K_Kilomet, K_Met, K_Mile, Me_Cent, Me_Feet, Me_Inch, Me_Kilomet,
            Me_Met, Me_Mile, Mi_Cent, Mi_Feet, Mi_Inch, Mi_Kilomet, Mi_Met, Mi_Mile, Grams, Kilograms, MetricTons, Ounces, MPounds, Slugs,
            G_Gram, G_Kilogram, G_MetTon, G_Ounce, G_Pound, G_Slug, K_Gram, K_Kilogram, K_MetTon, K_Ounce, K_Pound, K_Slug, MT_Gram, MT_Kilogram,
            MT_MetTon, MT_Ounce, MT_Pound, MT_Slug, O_Gram, O_Kilogram, O_MetTon, O_Ounce, O_Pound, O_Slug, P_Gram, P_Kilogram, P_MetTon, P_Ounce,
            P_Pound, P_Slug, S_Gram, S_Kilogram, S_MetTon, S_Ounce, S_Pound, S_Slug, Btus_Hour, FootPounds_Second, Horsepower, Joules_Second, Watts,
            B_Btus_Hour, B_FootPounds_Second, B_Horsepower, B_Joules_Second, B_Watts, F_Btus_Hour, F_FootPounds_Second, F_Horsepower, F_Joules_Second,
            F_Watts, H_Btus_Hour, H_FootPounds_Second, H_Horsepower, H_Joules_Second, H_Watts, J_Btus_Hour, J_FootPounds_Second, J_Horsepower,
            J_Joules_Second, J_Watts, W_Btus_Hour, W_FootPounds_Second, W_Horsepower, W_Joules_Second, W_Watts, Celsius, Farenheit, Kelvin, C_Celsius,
            C_Farenheit, C_Kelvin, F_Celsius, F_Farenheit, F_Kelvin, K_Celsius, K_Farenheit, K_Kelvin, Days, Seconds, Years, D_Days,
            D_Seconds, D_Years, S_Days, S_Seconds, S_Years, Y_Days, Y_Seconds, Y_Years, Centimeters_Second, Feet_Second, Kilometers_Hour, 
            Meters_Second, Miles_Hour, Miles_Minute, CS_Centimeters_Second, CS_Feet_Second, CS_Kilometers_Hour, CS_Meters_Second, CS_Miles_Hour,
            CS_Miles_Minute, FS_Centimeters_Second, FS_Feet_Second, FS_Kilometers_Hour, FS_Meters_Second, FS_Miles_Hour, FS_Miles_Minute,
            KH_Centimeters_Second, KH_Feet_Second, KH_Kilometers_Hour, KH_Meters_Second, KH_Miles_Hour, KH_Miles_Minute, MS_Centimeters_Second,
            MS_Feet_Second, MS_Kilometers_Hour, MS_Meters_Second, MS_Miles_Hour, MS_Miles_Minute, MH_Centimeters_Second, MH_Feet_Second, 
            MH_Kilometers_Hour, MH_Meters_Second, MH_Miles_Hour, MH_Miles_Minute, MM_Centimeters_Second, MM_Feet_Second, MM_Kilometers_Hour,
            MM_Meters_Second, MM_Miles_Hour, MM_Miles_Minute, CubicCentimeters, CubicFeet, CubicInches, CubicMeters, Gallons, Liters, Quarts,
            CC_CubicCentimeters, CC_CubicFeet, CC_CubicInches, CC_CubicMeters, CC_Gallons, CC_Liters, CC_Quarts, CF_CubicCentimeters, 
            CF_CubicFeet, CF_CubicInches, CF_CubicMeters, CF_Gallons, CF_Liters, CF_Quarts, CI_CubicCentimeters, CI_CubicFeet, CI_CubicInches,
            CI_CubicMeters, CI_Gallons, CI_Liters, CI_Quarts, CM_CubicCentimeters, CM_CubicFeet, CM_CubicInches, CM_CubicMeters, CM_Gallons,
            CM_Liters, CM_Quarts, G_CubicCentimeters, G_CubicFeet, G_CubicInches, G_CubicMeters, G_Gallons, G_Liters, G_Quarts, L_CubicCentimeters,
            L_CubicFeet, L_CubicInches, L_CubicMeters, L_Gallons, L_Liters, L_Quarts, Q_CubicCentimeters, Q_CubicFeet, Q_CubicInches,
            Q_CubicMeters, Q_Gallons, Q_Liters, Q_Quarts, End
        };


        public double convertUnit(double toConvert)
        {
            double convertedValue = 0.0;
            States currentState = States.Start;
            switch (currentState)
            {
                case States.Start:
                    //Assign top value
                    break;
                case States.Acceleration:
                    break;
                case States.Angle:
                    break;
                case States.Area:
                    break;
                case States.Energy:
                    break;
                case States.Force:
                    break;
                case States.Length:
                    break;
                case States.Mass:
                    break;
                case States.Power:
                    break;
                case States.Temperature:
                    break;
                case States.Time:
                    break;
                case States.Velocity:
                    break;
                case States.Volume:
                    break;
                case States.Cent_SqSec:
                    break;
                case States.Met_SqSec:
                    break;
                case States.Feet_SqSec:
                    break;
                case States.CSS_Cent_SqSec:
                    break;
                case States.CSS_Met_SqSec:
                    break;
                case States.CSS_Feet_SqSec:
                    break;
                case States.MSS_Cent_SqSec:
                    break;
                case States.MSS_Met_SqSec:
                    break;
                case States.MSS_Feet_SqSec:
                    break;
                case States.FSS_Cent_SqSec:
                    break;
                case States.FSS_Met_SqSec:
                    break;
                case States.FSS_Feet_SqSec:
                    break;
                case States.Degrees:
                    break;
                case States.Gradians:
                    break;
                case States.Radians:
                    break;
                case States.D_Deg:
                    break;
                case States.D_Grad:
                    break;
                case States.D_Rad:
                    break;
                case States.G_Deg:
                    break;
                case States.G_Grad:
                    break;
                case States.G_Rad:
                    break;
                case States.R_Deg:
                    break;
                case States.R_Grad:
                    break;
                case States.R_Rad:
                    break;
                case States.Sq_Cent:
                    break;
                case States.Sq_Feet:
                    break;
                case States.Sq_Inch:
                    break;
                case States.Sq_Met:
                    break;
                case States.SC_Sq_Cent:
                    break;
                case States.SC_Sq_Feet:
                    break;
                case States.SC_Sq_Inch:
                    break;
                case States.SC_Sq_Met:
                    break;
                case States.SF_Sq_Cent:
                    break;
                case States.SF_Sq_Feet:
                    break;
                case States.SF_Sq_Inch:
                    break;
                case States.SF_Sq_Met:
                    break;
                case States.SI_Sq_Cent:
                    break;
                case States.SI_Sq_Feet:
                    break;
                case States.SI_Sq_Inch:
                    break;
                case States.SI_Sq_Met:
                    break;
                case States.SM_Sq_Cent:
                    break;
                case States.SM_Sq_Feet:
                    break;
                case States.SM_Sq_Inch:
                    break;
                case States.SM_Sq_Met:
                    break;
                case States.Btus:
                    break;
                case States.Calories:
                    break;
                case States.eV:
                    break;
                case States.FootPounds:
                    break;
                case States.Joules:
                    break;
                case States.KilowattHours:
                    break;
                case States.B_Btus:
                    break;
                case States.B_Calories:
                    break;
                case States.B_eV:
                    break;
                case States.B_FootPounds:
                    break;
                case States.B_Joules:
                    break;
                case States.B_KilowattHours:
                    break;
                case States.C_Btus:
                    break;
                case States.C_Calories:
                    break;
                case States.C_eV:
                    break;
                case States.C_FootPounds:
                    break;
                case States.C_Joules:
                    break;
                case States.C_KilowattHours:
                    break;
                case States.E_Btus:
                    break;
                case States.E_Calories:
                    break;
                case States.E_eV:
                    break;
                case States.E_FootPounds:
                    break;
                case States.E_Joules:
                    break;
                case States.E_KilowattHours:
                    break;
                case States.F_Btus:
                    break;
                case States.F_Calories:
                    break;
                case States.F_eV:
                    break;
                case States.F_FootPounds:
                    break;
                case States.F_Joules:
                    break;
                case States.F_KilowattHours:
                    break;
                case States.J_Btus:
                    break;
                case States.J_Calories:
                    break; 
                case States.J_eV:
                case States.J_FootPounds:
                    break;
                case States.J_Joules:
                    break;
                case States.J_KilowattHours:
                    break;
                case States.K_Btus:
                    break;
                case States.K_Calories:
                    break;
                case States.K_eV:
                    break;
                case States.K_FootPounds:
                    break;
                case States.K_Joules:
                    break;
                case States.K_KilowattHours:
                    break;
                case States.Newtons:
                    break;
                case States.Pounds:
                    break;
                case States.N_Newtons:
                    break;
                case States.N_Pounds:
                    break;
                case States.P_Newtons:
                    break;
                case States.P_Pounds:
                    break;
                case States.Centimeters:
                    break;
                case States.Feet:
                    break;
                case States.Inches:
                    break;
                case States.Kilometers:
                    break;
                case States.Meters:
                    break;
                case States.Miles:
                    break;
                case States.C_Cent:
                    break;
                case States.C_Feet:
                    break;
                case States.C_Inch:
                    break;
                case States.C_Kilomet:
                    break;
                case States.C_Met:
                    break;
                case States.C_Mile:
                    break;
                case States.F_Cent:
                    break;
                case States.F_Feet:
                    break;
                case States.F_Inch:
                    break;
                case States.F_Kilomet:
                    break;
                case States.F_Met:
                    break;
                case States.F_Mile:
                    break;
                case States.I_Cent:
                    break;
                case States.I_Feet:
                    break;
                case States.I_Inch:
                    break;
                case States.I_Kilomet:
                    break;
                case States.I_Met:
                    break;
                case States.I_Mile:
                    break;
                case States.K_Cent:
                    break;
                case States.K_Feet:
                    break;
                case States.K_Inch:
                    break;
                case States.K_Kilomet:
                    break;
                case States.K_Met:
                    break;
                case States.K_Mile:
                    break;
                case States.Me_Cent:
                    break;
                case States.Me_Feet:
                    break;
                case States.Me_Inch:
                    break;
                case States.Me_Kilomet:
                    break;
                case States.Me_Met:
                    break;
                case States.Me_Mile:
                    break;
                case States.Mi_Cent:
                    break;
                case States.Mi_Feet:
                    break;
                case States.Mi_Inch:
                    break;
                case States.Mi_Kilomet:
                    break;
                case States.Mi_Met:
                    break;
                case States.Mi_Mile:
                    break;
                case States.Grams:
                    break;
                case States.Kilograms:
                    break;
                case States.MetricTons:
                    break;
                case States.Ounces:
                    break;
                case States.MPounds:
                    break;
                case States.Slugs:
                    break;
                case States.G_Gram:
                    break;
                case States.G_Kilogram:
                    break;
                case States.G_MetTon:
                    break;
                case States.G_Ounce:
                    break;
                case States.G_Pound:
                    break;
                case States.G_Slug:
                    break;
                case States.K_Gram:
                    break;
                case States.K_Kilogram:
                    break;
                case States.K_MetTon:
                    break;
                case States.K_Ounce:
                    break;
                case States.K_Pound:
                    break;
                case States.K_Slug:
                    break;
                case States.MT_Gram:
                    break;
                case States.MT_Kilogram:
                    break;
                case States.MT_MetTon:
                    break;
                case States.MT_Ounce:
                    break;
                case States.MT_Pound:
                    break;
                case States.MT_Slug:
                    break;
                case States.O_Gram:
                    break;
                case States.O_Kilogram:
                    break;
                case States.O_MetTon:
                    break;
                case States.O_Ounce:
                    break;
                case States.O_Pound:
                    break;
                case States.O_Slug:
                    break;
                case States.P_Gram:
                    break;
                case States.P_Kilogram:
                    break;
                case States.P_MetTon:
                    break;
                case States.P_Ounce:
                    break;
                case States.P_Pound:
                    break;
                case States.P_Slug:
                    break;
                case States.S_Gram:
                    break;
                case States.S_Kilogram:
                    break;
                case States.S_MetTon:
                    break;
                case States.S_Ounce:
                    break;
                case States.S_Pound:
                    break;
                case States.S_Slug:
                    break;
                case States.Btus_Hour:
                    break;
                case States.FootPounds_Second:
                    break;
                case States.Horsepower:
                    break;
                case States.Joules_Second:
                    break;
                case States.Watts:
                    break;
                case States.B_Btus_Hour:
                    break;
                case States.B_FootPounds_Second:
                    break;
                case States.B_Horsepower:
                    break;
                case States.B_Joules_Second:
                    break;
                case States.B_Watts:
                    break;
                case States.F_Btus_Hour:
                    break;
                case States.F_FootPounds_Second:
                    break;
                case States.F_Horsepower:
                    break;
                case States.F_Joules_Second:
                    break;
                case States.F_Watts:
                    break;
                case States.H_Btus_Hour:
                    break;
                case States.H_FootPounds_Second:
                    break;
                case States.H_Horsepower:
                    break;
                case States.H_Joules_Second:
                    break;
                case States.H_Watts:
                    break;
                case States.J_Btus_Hour:
                    break;
                case States.J_FootPounds_Second:
                    break;
                case States.J_Horsepower:
                    break;
                case States.J_Joules_Second:
                    break;
                case States.J_Watts:
                    break;
                case States.W_Btus_Hour:
                    break;
                case States.W_FootPounds_Second:
                    break;
                case States.W_Horsepower:
                    break;
                case States.W_Joules_Second:
                    break;
                case States.W_Watts:
                    break;
                case States.Celsius:
                    break;
                case States.Farenheit:
                    break;
                case States.Kelvin:
                    break;
                case States.C_Celsius:
                    break;
                case States.C_Farenheit:
                    break;
                case States.C_Kelvin:
                    break;
                case States.F_Celsius:
                    break;
                case States.F_Farenheit:
                    break;
                case States.F_Kelvin:
                    break;
                case States.K_Celsius:
                    break;
                case States.K_Farenheit:
                    break;
                case States.K_Kelvin:
                    break;
                case States.Days:
                    break;
                case States.Seconds:
                    break;
                case States.Years:
                    break;
                case States.D_Days:
                    break;
                case States.D_Seconds:
                    break;
                case States.D_Years:
                    break;
                case States.S_Days:
                    break;
                case States.S_Seconds:
                    break;
                case States.S_Years:
                    break;
                case States.Y_Days:
                    break;
                case States.Y_Seconds:
                    break;
                case States.Y_Years:
                    break;
                case States.Centimeters_Second:
                    break;
                case States.Feet_Second:
                    break;
                case States.Kilometers_Hour:
                    break;
                case States.Meters_Second:
                    break;
                case States.Miles_Hour:
                    break;
                case States.Miles_Minute:
                    break;
                case States.CS_Centimeters_Second:
                    break;
                case States.CS_Feet_Second:
                    break;
                case States.CS_Kilometers_Hour:
                    break;
                case States.CS_Meters_Second:
                    break;
                case States.CS_Miles_Hour:
                    break;
                case States.CS_Miles_Minute:
                    break;
                case States.FS_Centimeters_Second:
                    break;
                case States.FS_Feet_Second:
                    break;
                case States.FS_Kilometers_Hour:
                    break;
                case States.FS_Meters_Second:
                    break;
                case States.FS_Miles_Hour:
                    break;
                case States.FS_Miles_Minute:
                    break;
                case States.KH_Centimeters_Second:
                    break;
                case States.KH_Feet_Second:
                    break;
                case States.KH_Kilometers_Hour:
                    break;
                case States.KH_Meters_Second:
                    break;
                case States.KH_Miles_Hour:
                    break;
                case States.KH_Miles_Minute:
                    break;
                case States.MS_Centimeters_Second:
                    break;
                case States.MS_Feet_Second:
                    break;
                case States.MS_Kilometers_Hour:
                    break;
                case States.MS_Meters_Second:
                    break;
                case States.MS_Miles_Hour:
                    break;
                case States.MS_Miles_Minute:
                    break;
                case States.MH_Centimeters_Second:
                    break;
                case States.MH_Feet_Second:
                    break;
                case States.MH_Kilometers_Hour:
                    break;
                case States.MH_Meters_Second:
                    break;
                case States.MH_Miles_Hour:
                    break;
                case States.MH_Miles_Minute:
                    break;
                case States.MM_Centimeters_Second:
                    break;
                case States.MM_Feet_Second:
                    break;
                case States.MM_Kilometers_Hour:
                    break;
                case States.MM_Meters_Second:
                    break;
                case States.MM_Miles_Hour:
                    break;
                case States.MM_Miles_Minute:
                    break;
                case States.CubicCentimeters:
                    break;
                case States.CubicFeet:
                    break;
                case States.CubicInches:
                    break;
                case States.CubicMeters:
                    break;
                case States.Gallons:
                    break;
                case States.Liters:
                    break;
                case States.Quarts:
                    break;
                case States.CC_CubicCentimeters:
                    break;
                case States.CC_CubicFeet:
                    break;
                case States.CC_CubicInches:
                    break;
                case States.CC_CubicMeters:
                    break;
                case States.CC_Gallons:
                    break;
                case States.CC_Liters:
                    break;
                case States.CC_Quarts:
                    break;
                case States.CF_CubicCentimeters:
                    break;
                case States.CF_CubicFeet:
                    break;
                case States.CF_CubicInches:
                    break;
                case States.CF_CubicMeters:
                    break;
                case States.CF_Gallons:
                    break;
                case States.CF_Liters:
                    break;
                case States.CF_Quarts:
                    break;
                case States.CI_CubicCentimeters:
                    break;
                case States.CI_CubicFeet:
                    break;
                case States.CI_CubicInches:
                    break;
                case States.CI_CubicMeters:
                    break;
                case States.CI_Gallons:
                    break;
                case States.CI_Liters:
                    break;
                case States.CI_Quarts:
                    break;
                case States.CM_CubicCentimeters:
                    break;
                case States.CM_CubicFeet:
                    break;
                case States.CM_CubicInches:
                    break;
                case States.CM_CubicMeters:
                    break;
                case States.CM_Gallons:
                    break;
                case States.CM_Liters:
                    break;
                case States.CM_Quarts:
                    break;
                case States.G_CubicCentimeters:
                    break;
                case States.G_CubicFeet:
                    break;
                case States.G_CubicInches:
                    break;
                case States.G_CubicMeters:
                    break;
                case States.G_Gallons:
                    break;
                case States.G_Liters:
                    break;
                case States.G_Quarts:
                    break;
                case States.L_CubicCentimeters:
                    break;
                case States.L_CubicFeet:
                    break;
                case States.L_CubicInches:
                    break;
                case States.L_CubicMeters:
                    break;
                case States.L_Gallons:
                    break;
                case States.L_Liters:
                    break;
                case States.L_Quarts:
                    break;
                case States.Q_CubicCentimeters:
                    break;
                case States.Q_CubicFeet:
                    break;
                case States.Q_CubicInches:
                    break;
                case States.Q_CubicMeters:
                    break;
                case States.Q_Gallons:
                    break;
                case States.Q_Liters:
                    break;
                case States.Q_Quarts:
                    break;
                case States.End:
                    break;
                case States.Undefined:
                    MessageBox.Show("Error: Undefined State. Please Restart Application");
                    break;
            }

            return convertedValue; //Keep returning 0? Maybe 
        }

        //FSM will use the above states and use a switch statement to control flow to the correct method calls.
    }
}
