# BRAVE
# Documentation/References

[Dev Guide: GITHUBxUNITY3D Guide](https://paper.dropbox.com/doc/Dev-Guide-GitHub--Am656hWa3VkMB7r992QumpdPAg-fzIDKjJWtTxSlHH2Ci02C)

[Dev Guide: Writing Good Code?](https://paper.dropbox.com/doc/Dev-Guide--AnV_77eNnc6eP0K35WzBOSeuAQ-YqjO9RlrgQb9VxxzY6zYj)

[Dev Guide: Asset Sources && Licensing](https://paper.dropbox.com/doc/Licensing--AoHQniMm3~EoC4PePMHY4TeTAQ-hPsVceaRyon9WRaLwMpXx)

[Designs](https://paper.dropbox.com/doc/Obstacle-Designs-wJKAWeRSqcvvriFQlyfNm)

[Dev Guide: Dev Workshop Slides](https://docs.google.com/presentation/d/1uA7DJ721k_3aIFCz0J_2lDHB5RPp09n2CT3_5SNLv3E/edit?usp=sharing)

[Obstacle Interface Class](https://paper.dropbox.com/doc/Obstacle-Interface-Class-PARENT--AnMYBme1k_kLVsXIOt4wyLTSAg-EtDIGGJ4UNaGECNtZvHpf)

[Solution Architecture: Obstacle Implementation Guide](https://paper.dropbox.com/doc/Obstacle-Implementation-Architecture--AnCxImsAM7LB_kJqql~DlKaTAg-VKBBZLaOhGmY3cVnmnFgb)

[Solution Architecture: Example Meditation Obstacle](https://paper.dropbox.com/doc/Meditation-Obstacle-Architecture--AnASf7RYcqSVYUF_HuCo8CyiAg-8wyKWobDQ516GbKHuh71o)

[Solution Architecture: Example Wim Hof Obstacle](https://paper.dropbox.com/doc/Wim-Hof-Obstacle-Architecture--AnBeA_SVqlQA8HX7r77_xKyIAg-jp7NB25FQrnEidHgeP7eL)

# Unity version is 2018.4.9f1

*Updated as of 7th of Feb 2020.*
## World API
  * environment (this is basically the scene)
    * contains:
       - Maze
        * Maze should be procedurally generated
       - User
    * attributes
       - static (basically this is just a rigid body)
## Obstacle API
  * should be an abstract class

## User API
  * attributes
    * position
  * actions (methods)
    * movement
      possibilities
      * 1 joystick to location
      * 2 joysticks for rotation and translation
      * headset for rotation, joystick for translation
    * selecting
      * ray gun
      * grabbing

## Module interactions
   obstacle, maze, user
