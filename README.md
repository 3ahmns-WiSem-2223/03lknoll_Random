# 03lknoll_Random
Warum könnte man den Zufall beim Programmieren brauchen?
Um z.B. unterschiedliche Spawnpoints (an anderer Position) der enemys zu bestimmen.

Was ist der Unterschied zwischen Random aus System bzw. aus UnityEngine?
System legt nur pseudo zufallszahlen an, das heißt das es keinen wirklichen zufallszahlen sind, sie werden aus verschiedenen Zahlen berechnet z.B. Zeit, ComputerLeistung, ...
![image-4-688x1024](https://user-images.githubusercontent.com/114598188/202546443-fdd79caa-b3ca-488d-86da-631e9847ece8.png)
![image-5-688x1024](https://user-images.githubusercontent.com/114598188/202546454-402783a5-a6d2-4164-a0d9-26088d673759.png)

UnityEngine sind wirklich zufällige Zahlen aber es geht sehr schwer zum ausprobieren des spieles.
![image-3-688x1024](https://user-images.githubusercontent.com/114598188/202545969-bd57d04a-8cdc-4fc8-8e62-60706e19a1c4.png)![image-2-688x1024](https://user-images.githubusercontent.com/114598188/202545980-b64fc3fa-8b99-4335-99e2-4efd0ac65886.png)


Warum ist es sinnvoll den seed zu setzen bei Random?
Seed ist der Startwert und durch diesen erhält man immer die gleiche Zahlenreihnfolge.

Was macht Random.Range?
Random.Range gibt einen float aus welcher innerhalb der Maximalen und Minimalen bereich befindet. Die werte der Maximalen und minimalen Zahlen können auch vorkommen. 
