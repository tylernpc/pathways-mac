(() => {
  "use strict";

  let response;
  let jsonData;
  let sentimentScores = []; // Moved initialization outside of the function

  async function mainLogic() {
    // Get user data for date range
    const dateString = document.getElementById("userDateRange").value;
    const [startDateStr, endDateStr] = dateString.split(" - ");
    const startDate = new Date(startDateStr);
    const endDate = new Date(endDateStr);

    // Initialize data
    const startDateYear = startDate.getFullYear();
    const startDateMonth = startDate.getMonth() + 1;
    const startDateDay = startDate.getDate();
    const endDateDay = endDate.getDate();

    // Check if selected days are within a 5-day range
    const weekCheck = endDateDay - startDateDay;
    if (weekCheck !== 4) {
      alert("Please only select a date range of exactly 5 days");
      return;
    }

    // Clear previous table rows and sentiment scores
    const informationTableBody = document.getElementById("information");
    informationTableBody.innerHTML = ""; 
    sentimentScores = [];

    // Loop through the selected date range
    for (let i = 0; i <= weekCheck; i++) {
      const currentDate = new Date(startDate);
      currentDate.setDate(startDateDay + i);
      const formattedDate = `${currentDate.getFullYear()}-${String(
        currentDate.getMonth() + 1
      ).padStart(2, "0")}-${String(currentDate.getDate()).padStart(2, "0")}`;

      // Fetch data for the current date
      let apiMainString = `https://tradestie.com/api/v1/apps/reddit?date=${startDateYear}-${String(
        startDateMonth
      ).padStart(2, "0")}-${String(i).padStart(2, "0")}`;
      try {
        jsonData = await retrieveJson(apiMainString);
        jsonData.forEach((data) => {
          const { ticker, sentiment_score: sentimentScore, sentiment } = data;

          // Add sentiment score to the array
          sentimentScores.push(sentimentScore);

          // Create new row
          const row = [ticker, sentimentScore, sentiment];
          const tr = document.createElement("tr");
          row.forEach((cellText) => {
            const td = document.createElement("td");
            td.textContent = cellText;
            tr.appendChild(td);
          });
          informationTableBody.appendChild(tr);
        });
      } catch (error) {
        console.error("Error fetching data:", error);
      }
    }
    updateChart(sentimentScores); // Update chart with new data
  }

  // Function to fetch JSON data
  async function retrieveJson(apiMainString) {
    response = await fetch(apiMainString);
    return await response.json();
  }

  // Chart configuration PROVIDED BY BOOTSTRAP, UTILIZED BY ME
  const ctx = document.getElementById("myChart");
  const myChart = new Chart(ctx, {
    type: "line",
    data: {
      labels: ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday"], 
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
