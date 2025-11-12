### Thema: **Todo-Listen-API**

### Beschreibung

Erstelle eine kleine Web-API, um Todo-Einträge zu verwalten.

### Anforderungen

- Route: `/api/todos`
- Methoden:
    - `GET /api/todos` → Gibt alle Todos zurück.
    - `GET /api/todos/{id}` → Gibt ein einzelnes Todo anhand der ID zurück.
    - `POST /api/todos` → Legt ein neues Todo an.
    - `PUT /api/todos/{id}` → Aktualisiert ein Todo.
    - `DELETE /api/todos/{id}` → Löscht ein Todo.

### Bonus

- Validiere, dass `Title` nicht leer ist.
- Implementiere eine In-Memory-Liste als „Datenbank“.