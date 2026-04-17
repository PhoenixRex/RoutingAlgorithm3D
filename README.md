# RoutingAlgorithm3D (In Development)


## Its In Development i just Started 



A C# program for 3D pathfinding between point A and point B. Each element in the space is cube-shaped with six sides that can each be open or closed. Using the BFS algorithm (Breadth-First Search), the program determines whether a continuous connection between the two points exists.

## How It Works

Each element in the 3D grid is represented as a cube with six sides:

- `top` / `bottom`
- `forward` / `backward`
- `left` / `right`

Each side can be **open** or **closed**. Two adjacent cubes are connected only if the shared side is open on both elements. The BFS algorithm then traverses the grid starting from point A and checks whether point B is reachable.

## Tech Stack

- **Backend:** C# / ASP.NET Core Web API
- **Algorithm:** Breadth-First Search (BFS)
- **API Docs:** Swagger / OpenAPI
- **Frontend (planned):** Angular (`http://localhost:4200`)
- **Frontend Animations (Planned):** Tree.js

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 7 or higher)

### Run the project

```bash
git clone https://github.com/PhoenixRex/RoutingAlgorithm3D.git
cd RoutingAlgorithm3D
dotnet run
```

The API will be available at:

```
http://localhost:5000
https://localhost:7001
```

Swagger UI:

```
http://localhost:5000/swagger
```

## API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/path/test` | Health check |
| POST | `/api/path/calculate` | Calculate path between A and B |

### Example Request

```json
POST /api/path/calculate
{
  "X": 3,
  "Y": 2,
  "Z": 5
}
```

## Project Structure

```
RoutingAlgorithm3D/
├── Controllers/
│   └── PathController.cs
├── Models/
│   ├── Box/
│   │   └── Box.cs
│   └── PathRequest.cs
├── Program.cs
└── RoutingAlgorithm3D.csproj
```

## License

MIT
