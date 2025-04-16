// Datos iniciales para usuarios, almacenados localmente
let users = JSON.parse(localStorage.getItem("users")) || [
  { name: "Marlon", balance: 100, password: "marlon123" },
  { name: "Amigo1", balance: 100, password: "amigo123" },
  { name: "Amigo2", balance: 100, password: "amigo1234" },
];

// Guardar usuarios en localStorage
function saveToLocalStorage() {
  localStorage.setItem("users", JSON.stringify(users));
}

// Función para consultar el balance de un usuario
function showBalance() {
  const username = document.getElementById("username").value;
  const password = document.getElementById("password").value;
  const balanceDisplay = document.getElementById("balance");

  const user = users.find(u => u.name === username);

  if (!user) {
    balanceDisplay.innerText = "Usuario no encontrado";
    return;
  }

  if (user.password !== password) {
    balanceDisplay.innerText = "Contraseña incorrecta";
    return;
  }

  balanceDisplay.innerText = user.balance;
}

// Función para registrar una transacción
function registerTransaction() {
  const sender = document.getElementById("sender").value;
  const senderPassword = document.getElementById("sender-password").value;
  const receiver = document.getElementById("receiver").value;
  const amount = parseInt(document.getElementById("amount").value, 10);

  const senderUser = users.find(u => u.name === sender);
  const receiverUser = users.find(u => u.name === receiver);

  if (!senderUser || !receiverUser) {
    alert("Remitente o destinatario no válido");
    return;
  }

  if (senderUser.password !== senderPassword) {
    alert("Contraseña del remitente incorrecta");
    return;
  }

  if (senderUser.balance < amount) {
    alert("Fondos insuficientes");
    return;
  }

  senderUser.balance -= amount;
  receiverUser.balance += amount;

  saveToLocalStorage();

  alert("Transacción registrada con éxito");
}

// Inicializar localStorage si no hay datos
saveToLocalStorage();