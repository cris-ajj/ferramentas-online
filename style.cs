/* Reset básico */
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  font-family: Arial, sans-serif;
}

body {
  background-color: #f5f5f5;
  color: #333;
  text-align: center;
  padding: 50px 20px;
}

.container {
  max-width: 600px;
  margin: 0 auto;
  background-color: #fff;
  padding: 30px;
  border-radius: 12px;
  box-shadow: 0 4px 12px rgba(0,0,0,0.1);
}

h1 {
  color: #0077cc;
  margin-bottom: 10px;
}

p.description {
  margin-bottom: 30px;
  font-size: 1.1em;
}

.buttons {
  display: flex;
  flex-direction: column;
  gap: 15px;
  margin-bottom: 20px;
}

.buttons a.btn {
  text-decoration: none;
  background-color: #0077cc;
  color: #fff;
  padding: 15px;
  border-radius: 8px;
  font-weight: bold;
  transition: background-color 0.3s;
}

.buttons a.btn:hover {
  background-color: #005fa3;
}

#visitantes {
  font-weight: bold;
  margin-top: 20px;
  font-size: 1.1em;
}
