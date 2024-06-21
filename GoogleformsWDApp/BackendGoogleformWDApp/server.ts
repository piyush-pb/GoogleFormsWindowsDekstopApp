import * as fs from 'fs';
import * as express from 'express';
import * as bodyParser from 'body-parser';
import * as cors from 'cors';

const app = express();
const PORT = 3000;

app.use(bodyParser.json());
app.use(cors());

const DB_FILE = './db.json';

// Initialize submissions array
let submissions: any[] = [];

// Load initial submissions from file, if any
try {
    const data = fs.readFileSync(DB_FILE, 'utf8');
    submissions = JSON.parse(data);
} catch (err) {
    console.error('Error loading submissions from file:', err);
}

// Middleware to save submissions to file after each update
function saveSubmissionsToFile() {
    fs.writeFile(DB_FILE, JSON.stringify(submissions), 'utf8', (err) => {
        if (err) {
            console.error('Error saving submissions to file:', err);
        }
    });
}

app.get('/ping', (req, res) => {
    res.send('pong');
});

app.post('/submit', (req, res) => {
    const { name, email, phone, github_link, stopwatch_time } = req.body;
    const newSubmission = { name, email, phone, github_link, stopwatch_time };
    submissions.push(newSubmission);
    saveSubmissionsToFile(); // Save to file after each submission
    res.json({ success: true, submission: newSubmission });
});

app.get('/read', (req, res) => {
    const index = Number(req.query.index);
    if (index >= 0 && index < submissions.length) {
        res.json({ success: true, submission: submissions[index] });
    } else {
        res.status(404).json({ success: false, message: 'Submission not found' });
    }
});

app.listen(PORT, () => {
    console.log(`Server is running on http://localhost:${PORT}`);
});
