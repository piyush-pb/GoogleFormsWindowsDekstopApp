import express, { Request, Response } from 'express';
import bodyParser from 'body-parser';
import cors from 'cors';

const app = express();
const port = 3000;

app.use(bodyParser.json());
app.use(cors());

interface Submission {
    name: string;
    email: string;
    phone: string;
    github: string;
    stopwatchTime: number;
}

const submissions: Submission[] = [];

app.get('/submissions', (req: Request, res: Response) => {
    res.json(submissions);
});

app.post('/submissions', (req: Request, res: Response) => {
    const submission: Submission = req.body;
    submissions.push(submission);
    res.status(201).send(submission);
});

app.listen(port, () => {
    console.log(`Server running at http://localhost:${port}`);
});
