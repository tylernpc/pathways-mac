// declared var
let response;
let jsonData;
let apiString;

function mainLogic() {
  const dateString = document.getElementById("userDateRange").value;
  const [startDateStr, endDateStr] = dateString.split(" - ");

  const startDate = new Date(startDateStr);
  const endDate = new Date(endDateStr);

  const userBeginYear = startDate.getFullYear();
  const userBeginMonth = startDate.getMonth() + 1;
  const userBeginDay = startDate.getDate();

  const userEndYear = endDate.getFullYear();
  const userEndMonth = endDate.getMonth() + 1;
  const userEndDay = endDate.getDate();

  const informationTableBody = document.getElementById("information");

  // logical issue with this being a first of the month thing, for this example I am not taking that into account
  const weekCheck = userEndDay - userBeginDay;
  if (weekCheck >= 5 || weekCheck < 4) {
    alert("Please only select a date range between 5 days");
  } else {
    async function retrieveJson() {
      let apiBeginString = `${userBeginYear}-${userBeginMonth}-${userBeginDay}`;
      response = await fetch(apiBeginString);
      jsonBeginData = await response.json();
      return jsonBeginData;
    }
    async function retrieveMiddleJson() {
      for (let i = userBeginDay + 1; i < userEndDay; i++) {
        let apiMiddleString = `${userEndYear}-${userEndMonth}-${i}`;
        response = await fetch(apiMiddleString);
        jsonMiddleData = await response.json();
        return jsonMiddleData;
      }
    }
    async function retrieveEndJson() {
      let apiEndString = `${userEndYear}-${userEndMonth}-${userEndDay}`;
      response = await fetch(apiEndString);
      jsonEndData = await response.json();
      return jsonEndData;
    }
    const rows = [];
    rows.forEach((row) => {
      const tr = document.createElement("tr");
      row.forEach((cellText) => {
        const td = document.createElement("td");
        td.textContent = cellText;
        tr.appendChild(td);
      });
      informationTableBody.appendChild(tr);
    });
  }
}
