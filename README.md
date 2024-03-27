# ResoniteBakery
A light baking solution for Resonite.

# Prequisites
1. You must first install [ResoniteModLoader](https://github.com/resonite-modding-group/ResoniteModLoader).
2. You must also install [Blender Latest](https://www.blender.org/download/) you may install it anywhere (If you have issues please open an issue and/or message on discord under 989onan)
3. Done!

# Installing
1. Download the latest release of [ResoniteBakery](https://github.com/989onan/ResoniteBakery/releases).
3. Done!

# Usage
1. Equip a Developer Tool Tip and select "Create New".
2. Select the Light Baker Wizard option under "Editors".

# Known Issues
1. Oddly specific models don't play nice with Assimp and will crash Resonite instantly regardless of how they're imported/exported.
2. When using burn albedo, if the UV's are self overlapping or overlap in any way it will look awful and cut up.
3. Baked textures will come out at a lower resolution if the albedo is tiled too much and no upscaling is applied.
4. Upscaling is only reasonable up to 4096 depending on the item being baked.
5. Blender does not auto close itself. this is because the code was changed to let you view the final product before you close it. Useful since you can share screenshots of the result in blender for an issue ticket.
6. There seems to be strange artifacts at the seams. Not sure what I did wrong in the baking settings code
7. Currently only PBS_Metallic and PBS_Specular are supported for baking.

# Planned Features
1. Possibly the addition of procedural textures being supported.
2. Possibly using Unity as a method of light baking.

# Rules
1. You must adequately credit me if you use this software in your project.
2. Adequate credit requires you to at least have my name and the link to this project listed in a credits section of your project.
3. Credit Toxic_Cookie for the original addon.

# Contributing
Feedback and pull requests are welcome!
