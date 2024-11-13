let apiJobString = `http://localhost:3000/api/jobs`;
let apiUserString = `http://localhost:3000/api/users`;

// create function
async function createJob(jobData) {
  try {
    let response = await fetch(apiJobString, {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(jobData),
    });

    if (!response.ok) throw new Error("Failed to create job");

    const newJob = await response.json();
    console.log("Job created:", newJob);
  } catch (error) {
    console.error("Error creating job:", error);
  }
}

function utilizeCreateJob() {
  createJob({
    companyName: document.getElementById("companyName").value,
    jobTitle: document.getElementById("jobTitle").value,
    companyEmail: document.getElementById("companyEmail").value,
    jobState: document.getElementById("jobState").value,
    description: document.getElementById("description").value,
  });
}

// read function
async function getJobs() {
  let response = await fetch(apiJobString);
  let jsonData = await response.json();

  for (let job of jsonData) {
    console.log(job);

    clearInnerHTML();

    for (let job of jsonData) {
      document.getElementById(
        "output-formatted"
      ).innerHTML += `<div class="job-item">
                <p>Company: ${job.companyName || "N/A"}</p>
                <p>Job Title: ${job.jobTitle || "N/A"}</p>
                <p>Email: ${job.companyEmail || "N/A"}</p>
                <p>State: ${job.jobState || "N/A"}</p>
                <p>Description: ${job.description || "N/A"}</p>
             </div>`;
    }
  }

  console.log(jsonData);
}

function clearInnerHTML() {
  document.getElementById("output-formatted").innerHTML = "";
}

// update function
async function updateJob(jobID, updatedData) {
  try {
    let response = await fetch(`${apiJobString}/${jobID}`, {
      method: "PUT",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(updatedData),
    });

    if (!response.ok) throw new Error("Failed to update job");

    const updatedJob = await response.json();
    console.log("Job updated:", updatedJob);
  } catch (error) {
    console.error("Error updating job:", error);
  }
}

// delete function
async function deleteJob(jobID) {
  try {
    let response = await fetch(`${apiJobString}/${jobID}`, {
      method: "DELETE",
    });

    if (!response.ok) throw new Error("Failed to delete job");

    console.log("Job deleted");
  } catch (error) {
    console.error("Error deleting job:", error);
  }
}

// Example usage:
// deleteJob(1);

// user logic below
// create function
async function createUser(userData) {
  try {
    let response = await fetch(apiUserString, {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(userData),
    });

    if (!response.ok) throw new Error("Failed to create user");

    const newUser = await response.json();
    console.log("User created:", newUser);
  } catch (error) {
    console.error("Error creating user:", error);
  }
}

function utilizeCreateUser() {
  createUser({
    userType: document.getElementById("userType").value,
    username: document.getElementById("username").value,
    password: document.getElementById("password").value,
  });
}

// Login function
async function login() {
  try {
    let response = await fetch(apiUserString, {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify({
        username: document.getElementById("username").value,
        password: document.getElementById("password").value,
      }),
    });

    if (!response.ok) throw new Error("Login failed");

    const loggedInUser = await response.json();

    console.log("Login successful:", loggedInUser);
  } catch (error) {
    console.error("Error logging in:", error);
  }
}
