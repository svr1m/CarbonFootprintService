# Carbon Footprint Calculator (ASP.NET)

This project consists of:
- A Web Service (`CarbonFootprintService`) built in ASP.NET (.NET Framework)
- A Client Web App (`CarbonFootprintClientApp`) that consumes the service

## Features

✅ Calculate CO2 emissions based on:
- Energy consumption  
- Transportation distance  
- Waste generation  

✅ Clean, responsive UI using Bootstrap  
✅ Total and breakdown view of footprint  
✅ Proper error handling for invalid inputs

## 🛠 Setup Instructions

1. Open `CarbonFootprintSolution.sln` in **Visual Studio 2022**.
2. **Build** and **Run** `CarbonFootprintService` first.
   - Copy its URL (e.g., http://localhost:12345/CarbonService.asmx)
3. Open `CarbonFootprintClientApp`.
   - Right-click → **Add Service Reference** → Paste the URL
   - Click Advanced → Add Web Reference → Name it `CarbonRef`
4. Set `CarbonCalculator.aspx` as **Start Page**.
5. Press `F5` to run the full solution.

## 📦 Technologies Used

- ASP.NET Web Forms (.NET Framework)
- ASMX Web Services
- Bootstrap 5
- Visual Studio 2022

## 🤝 Contributing

Feel free to fork the repository and submit pull requests.

## 📄 License

MIT License
