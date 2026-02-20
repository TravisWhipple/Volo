# Project Migration Context

Source:
- Unity 5.5.0f3

Target:
- Unity 6 (latest)

Constraints:
- Preserve runtime behavior
- No architectural redesign unless required
- Minimize refactors
- Built-in Render Pipeline (no URP migration yet)
- Legacy Input system retained
- .NET Standard 2.1
- No new third-party dependencies

Known Issues:
- Uses legacy WWW
- Uses old UnityEngine.Networking
- Custom editor scripts present
- 12 custom CG shaders

Migration Strategy:
- Mechanical fixes first (API, namespaces)
- Systemic migrations only when compile-blocked
- Ollama first, Claude escalation second
