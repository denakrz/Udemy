let express = require("express");

const app = express();
const port = 4500;

app.get('/', (req,res) => {
    res.end('Hello World!\n');
});

app.listen(port, () => {
    console.log(`Server running at ${port}/`)
});