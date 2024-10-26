(() => {
  "use strict";

  let response;
  let jsonData;
  let sentimentScores = [];

  async function mainLogic() {
    const dateString = document.getElementById("userDateRange").value;
    const [startDateStr, endDateStr] = dateString.split(" - ");

    const startDate = new Date(startDateStr);
    const endDate = new Date(endDateStr);

    const startDateYear = startDate.getFullYear();
    const startDateMonth = (startDate.getMonth() + 1).toString().padStart(2, '0'); // Ensure two-digit month
    const startDateDay = startDate.getDate();
    const endDateDay = endDate.getDate();

    const weekCheck = endDateDay - startDateDay;
    if (weekCheck >= 5 || weekCheck < 4) {
      alert("Please only select a date range between 5 days");
      return; // Exit if the check fails
    }

    async function retrieveJson(dateString) {
      const proxyUrl = "https://api.allorigins.win/get?url=";
      const apiUrl = `${proxyUrl}${encodeURIComponent(dateString)}`;
  
      try {
          response = await fetch(apiUrl);
          if (!response.ok) {
              throw new Error(`HTTP error! status: ${response.status}`);
          }
          const data = await response.json();
          const jsonResponse = JSON.parse(data.contents); // Parse the JSON from the response
  
          console.log('API Response:', jsonResponse); // Log the API response for debugging
          return jsonResponse;
      } catch (error) {
          console.error('Error fetching data:', error);
          alert('Failed to fetch data. Please check the console for more details.');
          return null; // Return null if there was an error
      }
    }

    const informationTableBody = document.getElementById("information");
    informationTableBody.innerHTML = ""; // Clear previous rows
    sentimentScores = []; // Clear previous scores before populating new data

    // Loop through the date range
    for (let i = startDateDay; i <= endDateDay; i++) {
      let formattedDate = `${startDateYear}-${startDateMonth}-${i.toString().padStart(2, '0')}`; // Ensure two-digit day
      let apiMainString = `https://tradestie.com/api/v1/apps/reddit?date=${formattedDate}`;
      
      jsonData = await retrieveJson(apiMainString);

      if (!jsonData) continue; // Skip if there's an error

      // Adjust based on the actual structure of jsonData
      console.log(`Data for ${formattedDate}:`, jsonData); // Log data for each date
      const ticker = jsonData.ticker || "N/A";
      const sentimentScore = jsonData.sentiment_score || 0;
      const sentiment = jsonData.sentiment || "Unknown";

      // Add sentiment score to the array
      sentimentScores.push(sentimentScore);

      // Create table row
      const row = [ticker, sentimentScore, sentiment];
      const tr = document.createElement("tr");
      row.forEach((cellText) => {
        const td = document.createElement("td");
        td.textContent = cellText;
        tr.appendChild(td);
      });
      informationTableBody.appendChild(tr);
    }

    updateChart(sentimentScores); // Update chart with new data
  }

  // Chart configuration
  const ctx = document.getElementById("myChart");
  const myChart = new Chart(ctx, {
    type: "line",
    data: {
      labels: ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday"], // Adjust labels as needed
      datasets: [
        {
          data: [],
          lineTension: 0,
          backgroundColor: "transparent",
          borderColor: "#007bff",
          borderWidth: 4,
          pointBackgroundColor: "#007bff",
        },
      ],
    },
    options: {
      plugins: {
        legend: {
          display: false,
        },
        tooltip: {
          boxPadding: 3,
        },
      },
    },
  });

  // Function to update the chart with new data
  function updateChart(sentimentScores) {
    myChart.data.datasets[0].data = sentimentScores;
    myChart.update();
  }

  // Expose mainLogic to the global scope
  window.mainLogic = mainLogic;
})();
