
# Team Management API Usage Guide

This guide demonstrates how to interact with a local Team Management API using `curl` commands.

> ⚠️ **Note:** If accessing `https://localhost:5001/teams` gives an error, use the HTTP version instead:  
> `http://localhost:5000/teams`

---

## 🌐 Get All Teams
```bash
curl --insecure https://localhost:5001/teams
# OR if HTTPS doesn't work:
curl http://localhost:5000/teams 
```

## ➕ Create New Teams

### Create a New Team
```bash
curl -H "Content-Type:application/json" -X POST  -d "{\"id\":\"b52baa63-d511-417e-9e54-7aab04286281\",\"name\":\"Web Wizards\"}" http://localhost:5166/teams
```

### Create Two More Teams
```bash
curl -H "Content-Type:application/json" -X POST -d "{\"id\":\"c12baa63-d511-417e-9e54-7aab04286281\",\"name\":\"Frontend Dev\"}" http://localhost:5166/teams

curl -H "Content-Type:application/json" -X POST -d "{\"id\":\"d34baa63-d511-417e-9e54-7aab04286281\",\"name\":\"Backend Dev\"}" http://localhost:5166/teams
```

## 📄 Get Teams

### Get All Teams
```bash
curl -H "Content-Type:application/json" -X GET http://localhost:5166/teams
```

### Get Single Team by ID
```bash
curl -H "Content-Type:application/json" -X GET http://localhost:5166/teams/b52baa63-d511-417e-9e54-7aab04286281
```

## 🔄 Update Team Details
```bash
curl -H "Content-Type:application/json" -X PUT -d "{\"id\":\"b52baa63-d511-417e-9e54-7aab04286281\",\"name\":\"Full Stack Dev\"}" http://localhost:5166/teams/b52baa63-d511-417e-9e54-7aab04286281
```

## ❌ Delete a Team
```bash
curl -H "Content-Type:application/json" -X DELETE http://localhost:5166/teams/b52baa63-d511-417e-9e54-7aab04286281
```

## 👥 Add Members to Teams

### Add Member to Backend Dev
```bash
curl -H "Content-Type:application/json" -X POST -d "{\"id\":\"f11baa63-d511-417e-9e54-7aab04286281\",\"firstName\":\"Vishu\",\"lastName\":\"Saini\"}" http://localhost:5166/teams/d34baa63-d511-417e-9e54-7aab04286281/members
```

### Add Member to Frontend Dev
```bash
curl -H "Content-Type:application/json" -X POST -d "{\"id\":\"f13baa63-d511-417e-9e54-7aab04286281\",\"firstName\":\"Vipul\",\"lastName\":\"Patil\"}" http://localhost:5166/teams/c12baa63-d511-417e-9e54-7aab04286281/members
```

## ✅ Final Check - Get All Teams
```bash
curl -H "Content-Type:application/json" -X GET http://localhost:5166/teams
```

---

### 🧠 Team Summary

- **Team 1:** Backend Dev  
- **Team 2:** Frontend Dev  
