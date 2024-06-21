# Desktop App and Backend Server for Form Submissions

## Desktop App Description

This desktop application allows users to create and view submissions through a user-friendly interface. 
Just like Google forms clone 
The application features two main functionalities:

### Main Form
- **View Submissions Button**: Opens a new form to view previously submitted forms.
- **Create New Submission Button**: Opens a new form to create a new submission with editable fields.

### View Submissions Form
- **Previous Button**: Navigates to the previous submission.
- **Next Button**: Navigates to the next submission.
- By default, the first submitted form entry is shown.

### Create Submission Form
- **Fields**: 
  - Name
  - Email
  - Phone Number
  - GitHub Repository Link
- **Stopwatch Button**: Allows users to start and pause a stopwatch. The stopwatch continues from the last paused time, without resetting to 0.
- **Submit Button**: Submits the form details to the backend server.
- **Keyboard Shortcuts**: 
  - `Ctrl + S`: Submits the form on the Create New Submission page.

### Evaluation Criteria
- The app is a Windows Desktop App.
- Built with Visual Studio using Visual Basic.
- Capable of creating new submissions.
- Includes functional keyboard shortcuts.
- The code is available on a public GitHub repository.

### Additional Features (Optional)
- Option to delete submitted forms.
- Option to edit submitted forms.
- Enhanced styling of the forms.

## Backend Server Description

The backend server handles API calls for saving and retrieving submissions. It is built using Express and TypeScript, with submissions stored in a JSON file.

### Endpoints
- **/ping (GET)**: Returns `True`.
- **/submit (POST)**: Accepts parameters `name`, `email`, `phone`, `github_link`, and `stopwatch_time`.
- **/read (GET)**: Accepts a query parameter `index` to read the (index+1)th form submission.

### JSON Database
- A JSON file (`db.json`) is used to store submissions in a structured format.

### Evaluation Criteria
- The server is an Express server built with TypeScript.
- Implements the `/ping`, `/submit`, and `/read` endpoints.
- The code is available on a public GitHub repository.
- Includes clear instructions in the README on how to run the server.

### Additional Features (Optional)
- Option to delete submitted forms.
- Option to edit submitted forms.
- Searching forms by email ID.

## Instructions to Run the Backend Server

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/yourusername/repo-name.git
   ```bash
   cd repo-name
   ```bash
   npm install
   ```bash
   npm start
