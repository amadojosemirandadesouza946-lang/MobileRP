MobileRP - PRO package (GTA RP Mobile style)

What I generated:
- Full Unity project skeleton (scenes, scripts, lowpoly models)
- Advanced map generator (grid city, plazas, roads)
- HUDManager (health, money, wanted stars)
- Character customization (gender + simple options)
- Player controller and simple movement
- Server stub (Node.js + SQLite) for registration/login (runs on port 3000)
- GitHub Actions GameCI template (build Android automatically on push)
- Instructions file about keystore and CI secrets

How to use:
1. Download and extract this project.
2. Open in Unity Hub (2022.3.x recommended).
3. Create prefabs from OBJ models (building, road, car, male/female).
4. Assign prefabs to AdvancedMapGenerator in MainCity scene.
5. Open LoginScene, hook UI InputFields to LoginManager, set server URL if you run server.
6. Start server (node server.js) on a computer or cloud instance to test login/registration endpoints.

If you want I can:
- Create ready-to-import Unity UI YAML scenes for login and loading (so you don't need to wire UI manually).
- Create textured lowpoly models (PNG textures) and animated characters.
- Prepare a deploy script to run the Node server on a cheap VPS (DigitalOcean) step-by-step.
