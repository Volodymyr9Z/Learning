class ClientViewModel {
  constructor(data) {
    this.id = data.id;
    this.name = data.name;
    this.contact = data.contact;
    this.phone = data.phone;
  }
}

let client = new ClientViewModel({
  id: 1,
  name: "Bob's Pizza",
  contact: "Shawn",
  phone: "555-1212"
});

client.id = 2;
client.id = "Hello World";

