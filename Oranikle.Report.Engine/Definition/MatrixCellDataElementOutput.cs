/* ====================================================================
   

   
	
   
   
   

       

   
   
   
   
   


   
   
*/
using System;

namespace Oranikle.Report.Engine
{
	///<summary>
	/// Handle the Matrix Cell dataElement enumeration: output, nooutput
	///</summary>
	public enum MatrixCellDataElementOutputEnum
	{
		Output,				// Indicates the cell should appear in the output
		NoOutput			// Indicates the cell should not appear in the output		
	}
	public class MatrixCellDataElementOutput
	{
		static public MatrixCellDataElementOutputEnum GetStyle(string s, ReportLog rl)
		{
			MatrixCellDataElementOutputEnum rs;

			switch (s)
			{		
				case "Output":
					rs = MatrixCellDataElementOutputEnum.Output;
					break;
				case "NoOutput":
					rs = MatrixCellDataElementOutputEnum.NoOutput;
					break;
				default:		
					rl.LogError(4, "Unknown MatrixCellDataElementOutput '" + s + "'.  Output assumed.");
					rs = MatrixCellDataElementOutputEnum.Output;
					break;
			}
			return rs;
		}
	}

}
