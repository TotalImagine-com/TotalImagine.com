# (Idea, Algorithm, Procedural, Art, Nature) Voxel Tree

1. 2000cmx2000cmx2000cm
2. Object oriented branches
3. Leaves are separate objects
4. Voxels are only there to handle collision and space - not as object type
5. Newer branches randomly spawn new branches at cell level
6. Cells can grow (tangentially) and longitudally over time
7. Each branch has a "programmed growing direction" - only new branches take new orientations: the new orientation is taken as "45 degrees away from current orientation and preferably towards 'up' direction" (also likely affected by self weight)
8. Tip of branch may split, in which case old branch stops growing longitutally.
9. Each branch is a 1-d voxel list of thickness values
10. Branches are attached to (the beginning node) other branches at such voxel index locations.

(Remark, #20220914) However today I learn string-rewriting based L system and https://github.com/mxgmn/MarkovJunior, both are amazing. Even so - I think it's worth trying implementing and exploring possibilities with our original approach.

(Reference) There is a book called Nature of Code written by Daniel Shiffman which using Processing and talks about a few topics that is new to us.