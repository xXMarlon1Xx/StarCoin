body {
  font-family: 'Poppins', sans-serif;
  margin: 0;
  padding: 0;
  background: linear-gradient(135deg, #9be15d, #00e3ae);
  color: #333;
}

.header {
  text-align: center;
  padding: 20px;
  color: white;
  background-color: #4caf50;
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.2);
}

.header h1 {
  font-size: 2.5em;
  margin: 0;
}

.header p {
  font-size: 1.2em;
  margin: 0;
}

.container {
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
  padding: 30px;
}

.card {
  background: #fff;
  border-radius: 10px;
  box-shadow: 0 4px 10px rgba(0, 0, 0, 0.2);
  margin: 20px;
  padding: 20px;
  width: 90%;
  max-width: 400px;
  text-align: center;
}

.card h2 {
  color: #333;
  margin-bottom: 15px;
}

input {
  width: calc(100% - 20px);
  margin: 10px 0;
  padding: 10px;
  border-radius: 5px;
  border: 1px solid #ccc;
  font-size: 1em;
}

button {
  width: calc(100% - 20px);
  padding: 10px;
  margin-top: 15px;
  border: none;
  border-radius: 5px;
  font-size: 1em;
  font-weight: 600;
  color: white;
  background: linear-gradient(135deg, #4caf50, #388e3c);
  cursor: pointer;
  transition: background 0.3s ease, transform 0.3s ease;
}

button:hover {
  background: linear-gradient(135deg, #388e3c, #4caf50);
  transform: scale(1.05);
}

button.btn-alt {
  background: linear-gradient(135deg, #00c6ff, #0072ff);
}

button.btn-alt:hover {
  background: linear-gradient(135deg, #0072ff, #00c6ff);
}

footer {
  text-align: center;
  padding: 10px;
  background-color: #4caf50;
  color: white;
  margin-top: 20px;
}