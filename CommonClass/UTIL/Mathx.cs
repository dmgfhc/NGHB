using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;
//using System.Math;


namespace CommonClass
{
	public class Mathx
	{
		
		
		//
		//数据修约
		// sData,iScale,dSpit 分别为 需要修约的数据，保留的小数位，修约间隔
		//
		public static decimal Roundx(decimal sData, int iScale, decimal dSpit)
		{
			
			decimal dec;
			decimal temp;
			
			if (dSpit == 1)
			{
				dec = System.Math.Round(sData, iScale);
				return dec;
			}
			if (dSpit < 1)
			{
				
				temp = System.Math.Round(sData / System.Math.Abs(dSpit));
				dec = temp * System.Math.Abs(dSpit);
				return dec;
			}
			else
			{
				dec = System.Convert.ToDecimal(Conversion.Int(System.Math.Round(sData / dSpit, 0)) * dSpit);
				return dec;
				
			}
			
		}
		
		// Methods
		//十进转62进制 0-9，A-Z，a-z
		//
		public static string Convert10To62Metric(long value)
		{
			string str = "";
			long num = value;
			int num2 = System.Convert.ToInt32(Math.Log(value, 62));
			int i = num2;
			while (i >= 0)
			{
				long num4 = System.Convert.ToInt32(Math.Pow(62, i));
				int num5 = System.Convert.ToInt32(num / num4);
				num = num - (num5 * num4);
				str = (string) (str + Mathx.NumToChar62(num5));
				i--;
			}
			return str;
		}
		//
		//判定是否为十进制数
		//
		public static bool Is10Metric(object value)
		{
			return FormatValidate.IsInteger(value.ToString());
		}
		
		//
		//62以内的数转换为一个数字（0-9）或字符（A-Z 、a-z)
		//
		private static string NumToChar62(int value)
		{
			char ch;
			string str = "";
			if (value < 10)
			{
				ch = Strings.Chr(System.Convert.ToInt32(48 + value));
				return ch.ToString();
			}
			if (value < 36)
			{
				ch = Strings.Chr(System.Convert.ToInt32(65 + (value - 10)));
				
				return ch.ToString();
			}
			if (value < 62)
			{
                str = Strings.Chr(System.Convert.ToInt32(97 + (value - 36))).ToString();
			}
			return str;
		}
		//
		//二进制到62进制之间任意进制之间整数的转换
		//
		public static string Base2Base(string InputNumber, int InputBase, int OutputBase)
		{
			int J;
			int K;
			double DecimalValue;
			int X;
			int MaxBase;
			int InputNumberLength;
			string NumericBaseData;
			string OutputValue;
			NumericBaseData = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
			MaxBase = NumericBaseData.Length;
			
			if ((InputBase > MaxBase) || (OutputBase > MaxBase))
			{
				//Base2Base = "N/A"
				return "N/A";
			}
			
			// */ Convert InputNumber to Base 10 /*
			InputNumberLength = InputNumber.Length;
			DecimalValue = 0;
			for (J = 1; J <= InputNumberLength; J++)
			{
				for (K = 1; K <= InputBase; K++)
				{
					if (InputNumber.Substring(J - 1, 1) == NumericBaseData.Substring(K - 1, 1))
					{
						DecimalValue = DecimalValue + Conversion.Int((K - 1) * (Math.Pow(InputBase, (InputNumberLength - J))) + 0.5);
					}
				}
			}
			
			// */ Convert the Base 10 value (DecimalValue) to the desired output base /*
			OutputValue = "";
			while (DecimalValue > 0)
			{
				X = System.Convert.ToInt32(Conversion.Int(((DecimalValue / OutputBase) - Conversion.Int(DecimalValue / OutputBase)) * OutputBase + 1.5));
				OutputValue = (string) (NumericBaseData.Substring(X - 1, 1) + OutputValue);
				DecimalValue = Conversion.Int(DecimalValue / OutputBase);
			}
			OutputValue = (string) (OutputValue == "" ? "0" : OutputValue);
			return OutputValue;
		}
		
		public static int average(FarPoint.Win.Spread.FpSpread ss, int irow, int icol1, int icol2)
		{
			int avg = 0;
			int count = 0;
			for (int i = icol1; i <= icol2; i++)
			{
				if (ss.Sheets[0].Cells.Get(irow, i).Text != "")
				{
					if (int.Parse((string) (ss.Sheets[0].Cells.Get(irow, i).Text)) != 0)
					{
						count++;
						avg += int.Parse(ss.Sheets[0].Cells.Get(irow, i).Text);
					}
				}
			}
			if (count != 0)
			{
				avg = System.Convert.ToInt32(System.Math.Round((double)(avg / count)));
			}
			
			return avg;
		}
		
		public static double averageDouble(FarPoint.Win.Spread.FpSpread ss, int irow, int icol1, int icol2, int scale)
		{
			double avg = 0;
			int count = 0;
			for (int i = icol1; i <= icol2; i++)
			{
				if (ss.Sheets[0].Cells.Get(irow, i).Text != "")
				{
					if (double.Parse((string) (ss.Sheets[0].Cells.Get(irow, i).Text)) != 0)
					{
						count++;
						avg += double.Parse(ss.Sheets[0].Cells.Get(irow, i).Text);
					}
				}
			}
			if (count != 0)
			{
				avg = (double) (Mathx.Roundx((decimal) (avg / count), scale, 1));
			}
			
			return avg;
		}
		
	}
	
	
	
	
}
