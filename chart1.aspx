<%@ Page Language="C#" AutoEventWireup="true" CodeFile="chart1.aspx.cs" Inherits="chart1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form2" runat="server">
        <div>
            <asp:Chart ID="Chart2" runat="server" Width="800px" Height="600px">            
                 <Legends>  
                    <asp:Legend Alignment="Center" Docking="Bottom" IsTextAutoFit="False" Name="Default"  
                        LegendStyle="Row" />  
                </Legends>  
                <Series>
                    <asp:Series Name="series" ChartType="Column" ></asp:Series>
                   <%-- <asp:Series Name="Humidity" ChartType="Column"></asp:Series>
                    <asp:Series Name="WindSpeed" ChartType="Column"></asp:Series>
                    <asp:Series Name="Winddirection" ChartType="Column"></asp:Series>
                    <asp:Series Name="SolarRadiation" ChartType="Column"></asp:Series>
                    <asp:Series Name="RainfalTodayTotal" ChartType="Column"></asp:Series>
                   --%>
                    
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1" BorderWidth="0" >
                        
                        <AxisY Title="AirTemperature(AVG)"></AxisY>
                    </asp:ChartArea>
                </ChartAreas>
            </asp:Chart>
        </div>
    </form>
  
</body>
</html>
