-- 1. ¿Qué consulta ejecutarías para obtener todos los clientes dentro de city_id = 312? Su consulta debe devolver el nombre, apellido, correo electrónico y dirección del cliente.
SELECT cus.first_name,cus.last_name,cus.email,ad.address
FROM customer cus
INNER JOIN address ad ON ad.address_id = cus.address_id
INNER JOIN city ci ON  ad.city_id = ci.city_id
WHERE ci.city_id =  312;

-- 2. ¿Qué consulta harías para obtener todas las películas de comedia? Su consulta debe devolver el título de la película, la descripción, el año de estreno, la calificación, las características especiales y el género (categoría).
SELECT pe.title,pe.description,pe.release_year,pe.rating,pe.special_features,ca.name as category
FROM film pe
INNER JOIN film_category fca ON pe.film_id = fca.film_id
INNER JOIN category ca ON ca.category_id = fca.category_id
WHERE ca.name = 'Comedy';

-- 3. ¿Qué consulta harías para obtener todas las películas unidas por actor_id = 5? Su consulta debe devolver la identificación del actor, el nombre del actor, el título de la película, la descripción y el año de lanzamiento.
SELECT ac.actor_id,CONCAT( ac.first_name,' ',ac.last_name )as Nombre_Completo,pe.title,pe.description,pe.release_year
FROM film pe
INNER JOIN film_actor fac ON pe.film_id = fac.film_id
INNER JOIN actor ac  ON ac.actor_id = fac.actor_id
WHERE ac.actor_id = 5;

-- 4. ¿Qué consulta ejecutaría para obtener todos los clientes en store_id = 1 y dentro de estas ciudades (1, 42, 312 y 459)? Su consulta debe devolver el nombre, apellido, correo electrónico y dirección del cliente
SELECT  CONCAT( cu.first_name,' ',cu.last_name )as Nombre_Completo,cu.email,ad.address
FROM customer cu
INNER JOIN address ad ON cu.address_id = ad.address_id
INNER JOIN city ci ON ci.city_id = ad.city_id
INNER JOIN store st ON st.store_id = cu.store_id
WHERE st.store_id = 1 AND ( ci.city_id = 1 OR  ci.city_id = 42  OR ci.city_id = 312 OR ci.city_id = 459);

-- 5. ¿Qué consulta realizarías para obtener todas las películas con una "calificación = G" y "característica especial = detrás de escena", unidas por actor_id = 15? Su consulta debe devolver el título de la película, la descripción, el año de lanzamiento, la calificación y la función especial. Sugerencia: puede usar la función LIKE para obtener la parte 'detrás de escena'.
SELECT pe.title,pe.description,pe.release_year,pe.rating,pe.special_features
FROM film pe
INNER JOIN film_actor fac ON pe.film_id = fac.film_id
INNER JOIN actor ac  ON ac.actor_id = fac.actor_id
WHERE  ac.actor_id = 15 AND pe.rating='G' AND pe.special_features LIKE '%Behind the Scenes%';


-- 6. ¿Qué consulta harías para obtener todos los actores que se unieron en el film_id = 369? Su consulta debe devolver film_id, title, actor_id y actor_name
SELECT pe.film_id, pe.title,ac.actor_id,CONCAT( ac.first_name,' ',ac.last_name )as Nombre_Completo
FROM film pe
INNER JOIN film_actor fac ON pe.film_id = fac.film_id
INNER JOIN actor ac  ON ac.actor_id = fac.actor_id
WHERE pe.film_id = 369;

-- 7.  ¿Qué consulta harías para obtener todas las películas dramáticas con una tarifa de alquiler de 2.99? Su consulta debe devolver el título de la película, la descripción, el año de estreno, la calificación, las características especiales y el género (categoría).
SELECT pe.title,pe.description,pe.release_year,pe.rating,pe.special_features,ca.name as category
FROM film pe
INNER JOIN film_category fca ON pe.film_id = fca.film_id
INNER JOIN category ca ON ca.category_id = fca.category_id
WHERE ca.name = 'Drama' AND pe.rental_rate = 2.99;

-- 8 ¿Qué consulta harías para obtener todas las películas de acción a las que se une SANDRA KILMER? Su consulta debe devolver el título de la película, la descripción, el año de estreno, la calificación, las características especiales, el género (categoría) y el nombre y apellido del actor.
SELECT pe.title,pe.description,pe.release_year,pe.rating,pe.special_features,ca.name as category,CONCAT( ac.first_name,' ',ac.last_name )as Nombre_Completo
FROM film pe
INNER JOIN film_actor fac ON pe.film_id = fac.film_id
INNER JOIN actor ac  ON ac.actor_id = fac.actor_id
INNER JOIN film_category fca ON pe.film_id = fca.film_id
INNER JOIN category ca ON ca.category_id = fca.category_id
WHERE ca.name = 'Action' AND CONCAT( ac.first_name,' ',ac.last_name ) = 'SANDRA KILMER';