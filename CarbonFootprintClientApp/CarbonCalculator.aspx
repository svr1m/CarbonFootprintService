<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CarbonCalculator.aspx.cs" Inherits="CarbonFootprintClientApp.CarbonCalculator" %>

<!DOCTYPE html>
<html>
<head>
    <title>Carbon Footprint Calculator</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        body {
            background-color: #f4f6f8;
            font-family: 'Segoe UI', sans-serif;
        }
        .container {
            margin-top: 50px;
            max-width: 700px;
            background-color: white;
            padding: 30px;
            border-radius: 15px;
            box-shadow: 0px 4px 20px rgba(0,0,0,0.1);
        }
        .form-label {
            font-weight: 500;
        }
        .result-box {
            margin-top: 20px;
            background-color: #e6f2ff;
            padding: 15px;
            border-left: 5px solid #007bff;
            border-radius: 8px;
        }
        h2 {
            text-align: center;
            color: #333;
            margin-bottom: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Carbon Footprint Calculator</h2>
            
            <div class="mb-3">
                <label class="form-label">Energy Consumption (kWh):</label>
                <asp:TextBox ID="txtEnergy" runat="server" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label class="form-label">Energy Emission Factor (kg CO2/kWh):</label>
                <asp:TextBox ID="txtEnergyFactor" runat="server" CssClass="form-control" />
            </div>

            <div class="mb-3">
                <label class="form-label">Distance Travelled (km):</label>
                <asp:TextBox ID="txtDistance" runat="server" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label class="form-label">Transport Emission Factor (kg CO2/km):</label>
                <asp:TextBox ID="txtTransportFactor" runat="server" CssClass="form-control" />
            </div>

            <div class="mb-3">
                <label class="form-label">Waste Produced (tonnes):</label>
                <asp:TextBox ID="txtWaste" runat="server" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label class="form-label">Waste Emission Factor (kg CO2/tonne):</label>
                <asp:TextBox ID="txtWasteFactor" runat="server" CssClass="form-control" />
            </div>

            <div class="d-grid gap-2">
                <asp:Button ID="btnCalculate" runat="server" Text="Calculate Footprint" CssClass="btn btn-primary btn-lg" OnClick="btnCalculate_Click" />
            </div>

            <div class="result-box mt-4">
                <asp:Label ID="lblResult" runat="server" Text="" CssClass="text-dark fs-5" />
            </div>
        </div>
    </form>
</body>
</html>
