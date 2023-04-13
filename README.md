# Spaceship Game

### ביצעתי שני שינויים במשחק חלליות שניתן לראות כאן : 

https://user-images.githubusercontent.com/73184238/231605846-1eb0daf1-f584-4c2b-86f4-4359cdf53ca7.mp4

### שינוי 1
שיניתי את קצב הירייה, על השחקן לחכות חצי שנייה בין ירייה לירייה הבאה.
ביצעתי את השינוי בסקריפט ClickSpawner, הוספתי משתנה בוליאני canShoot על מנת לשלוט בקצב הירייה. כאשר השחקן מנסה לירות השיטה Update בודקת אם canShoot הוא true, אם כן ()spawnObject נקראת ו canShoot מוגדר להיות false מה שמונע מהשחקן לירות שוב מיד. השתמשתי ב Coroutine על מנת לחכות חצי שנייה ולאחר מכן החזרתי את canShoot להיות true כדי לאפשר לשחקן לירות שוב.

### לפני השינוי בScript: 

![לפני שינוי קצב ירייה](https://github.com/LO-Games/Spaceship-Game/blob/main/CodeScreenshots/%D7%9C%D7%A4%D7%A0%D7%99%20%D7%A9%D7%99%D7%A0%D7%95%D7%99%20%D7%A7%D7%A6%D7%91%20%D7%99%D7%A8%D7%99%D7%99%D7%94.PNG)

### אחרי השינוי בScript:

![אחרי שינוי קצב ירייה](https://github.com/LO-Games/Spaceship-Game/blob/main/CodeScreenshots/%D7%90%D7%97%D7%A8%D7%99%20%D7%A9%D7%99%D7%A0%D7%95%D7%99%20%D7%A7%D7%A6%D7%91%20%D7%99%D7%A8%D7%99%D7%99%D7%94.PNG)

### שינוי 2 - מקורי

במקום שהחללית תיעלם בהתנגשות רציתי ליצור אפקט של חללית מושמדת לחלקים בעת ההתנגשות. יצרתי 8 חלקים של החללית ועבור כל חלק הוספתי רכיב Rigidbody.
בסקריפט DestroyOnTrigger2D יצרתי מערך של חלקי החללית, בפונ' OnTriggerEnter2D הנקראת בעת התנגשות יצרתי לולאה שתעבור על כל החלקים ועבור כל חלק תיצור אותו במיקום הנוכחי של החללית, לאחר מכן השתמשתי בפונ' AddForce של Rigidbody על מנת להוסיף כוח לאותו חלק ולתת לו כיוון אקראי בעת הפעלת הכוח. בסוף קראתי ל Destroy על מנת להשמיד את החללית ואת האובייקט השני המתנגש.

### לפני השינוי בScript: 

![לפני שינוי מקורי](https://github.com/LO-Games/Spaceship-Game/blob/main/CodeScreenshots/%D7%9C%D7%A4%D7%A0%D7%99%20%D7%A9%D7%99%D7%A0%D7%95%D7%99%20%D7%9E%D7%A7%D7%95%D7%A8%D7%99.PNG)

### אחרי השינוי בScript:

![אחרי שינוי מקורי](https://github.com/LO-Games/Spaceship-Game/blob/main/CodeScreenshots/%D7%90%D7%97%D7%A8%D7%99%20%D7%A9%D7%99%D7%A0%D7%95%D7%99%20%D7%9E%D7%A7%D7%95%D7%A8%D7%99.PNG) 
