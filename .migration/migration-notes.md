# Stats before migration

| File Type              | Count | Code                                                                                          |
|------------------------|-------|-----------------------------------------------------------------------------------------------|
| .cs                    | 1221  | `(Get-ChildItem -Recurse -Filter *.cs -Path .\Assets).Count`                                  |
| .cs (global)           | 2685  | `(Get-ChildItem -Recurse -Filter *.cs -Path .).Count`                                         |
| custom shader          | 132   | `(Get-ChildItem -Recurse -Include *.shader,*.cginc,*.shadergraph -Path .\Assets).Count`       |
| custom shader (global) | 136   | `(Get-ChildItem -Recurse -Include *.shader,*.cginc,*.shadergraph -Path .).Count`              |
| Native Plugins         | 237   | `(Get-ChildItem -Recurse -Include *.dll,*.bundle,*.so,*.aar,*.framework -Path .\Asset).Count` |
