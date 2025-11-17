const express = require('express');
const sqlite3 = require('sqlite3').verbose();
const app = express();
app.use(express.json());
const db = new sqlite3.Database('./data.db');
db.serialize(()=>{
  db.run('CREATE TABLE IF NOT EXISTS users (id TEXT PRIMARY KEY, name TEXT, password TEXT)');
});
app.post('/register',(req,res)=>{
  const {id,name,password} = req.body;
  db.run('INSERT OR REPLACE INTO users (id,name,password) VALUES (?,?,?)',[id,name,password], function(err){
    if(err) return res.status(500).json({error:err.message});
    res.json({ok:true});
  });
});
app.post('/login',(req,res)=>{
  const {id,password} = req.body;
  db.get('SELECT * FROM users WHERE id=?',[id], (err,row)=>{
    if(err) return res.status(500).json({error:err.message});
    if(!row) return res.status(404).json({error:'not found'});
    if(row.password !== password) return res.status(401).json({error:'invalid'});
    res.json({ok:true, name:row.name, id:row.id});
  });
});
app.listen(3000, ()=> console.log('Server running on port 3000'));
