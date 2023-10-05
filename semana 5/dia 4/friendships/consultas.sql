-- Ejercicio Principal
SELECT us.first_name, us.last_name, user2.first_name as friend_first_name, user2.last_name as friend_last_name
FROM  users us
LEFT JOIN friendships  fri ON fri.user_id = us.id
LEFT JOIN  users as user2 ON fri.friend_id = user2.id
WHERE us.id = user_id; 


-- Ejercicios adicionales 
-- 1 Devuelva a todos los usuarios que son amigos de Kermit, asegúrese de que sus nombres se muestren en los resultados.

SELECT 
    CONCAT(us.first_name, ' ', us.last_name) AS Kermit_Friends_Names
FROM
    users us
        LEFT JOIN
    friendships fri ON fri.user_id = us.id
        LEFT JOIN
    users AS user2 ON fri.friend_id = user2.id
WHERE
    us.id = user_id
        AND CONCAT(user2.first_name, ' ', user2.last_name) = 'Kermit The Frog'; 

-- 2 Devuelve el recuento de todas las amistades.

SELECT COUNT(*) as Total_Amistades
FROM  users us
LEFT JOIN friendships  fri ON fri.user_id = us.id
LEFT JOIN  users as user2 ON fri.friend_id = user2.id
WHERE us.id = user_id; 

-- 3 Descubre quién tiene más amigos y devuelve el recuento de sus amigos.
SELECT CONCAT(us.first_name,' ', us.last_name) AS Full_Name, COUNT(fri.friend_id) as Amigos
FROM  users us
LEFT JOIN friendships  fri ON fri.user_id = us.id
LEFT JOIN  users as user2 ON fri.friend_id = user2.id
WHERE us.id = user_id
GROUP BY Full_Name
ORDER BY Amigos DESC
LIMIT 1; 

-- 4 Crea un nuevo usuario y hazlos amigos de Eli Byers, Kermit The Frog y Marky Mark.
INSERT INTO `users` VALUES (6,'Juan','Alberto','2019-02-08 11:12:11',NULL);
INSERT INTO `friendships` VALUES (7,6,2,'2019-02-08 11:13:27',NULL),(8,6,4,'2019-02-08 11:13:27',NULL),(9,6,5,'2019-02-08 11:13:27',NULL);

-- 5 Devuelve a los amigos de Eli en orden alfabético. 
SELECT 
    CONCAT(us.first_name, ' ', us.last_name) AS Eli_Friends_Names
FROM
    users us
        LEFT JOIN
    friendships fri ON fri.user_id = us.id
        LEFT JOIN
    users AS user2 ON fri.friend_id = user2.id
WHERE
    us.id = user_id
        AND CONCAT(user2.first_name, ' ', user2.last_name) = 'Eli Byers'
        ORDER BY us.first_name; 
        
-- 6 Eliminar a Marky Mark de los amigos de Eli
DELETE FROM friendships
WHERE user_id = 2 AND friend_id = 5;

-- 7  Devuelve todas las amistades, mostrando solo el nombre y apellido de ambos amigos
SELECT CONCAT(us.first_name,' ', us.last_name) AS User_full_Name, CONCAT(user2.first_name,' ', user2.last_name) AS Friend_Full_Name 
FROM  users us
LEFT JOIN friendships  fri ON fri.user_id = us.id
LEFT JOIN  users as user2 ON fri.friend_id = user2.id
WHERE us.id = user_id; 