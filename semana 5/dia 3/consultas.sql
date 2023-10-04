-- 1. ¿Qué consulta harías para obtener todos los países que hablan esloveno? Tu consulta debe devolver el nombre del país, el idioma y el porcentaje de idioma. Tu consulta debe organizar el resultado por porcentaje de idioma en orden descendente. (1)

SELECT countries.name,languages.language, languages.percentage FROM  countries 
INNER JOIN languages ON countries.id = languages.country_id 
WHERE languages.language = 'Slovene'
ORDER BY languages.percentage DESC;

-- 2. ¿Qué consulta ejecutarías para mostrar el número total de ciudades para cada país? Su consulta debe devolver el nombre del país y el número total de ciudades. Tu consulta debe organizar el resultado por el número de ciudades en orden descendente.

SELECT co.name as Pais, COUNT(ci.id) AS TotalCiudades
FROM countries co
LEFT JOIN cities ci ON co.id = ci.country_id
GROUP BY co.name
ORDER BY TotalCiudades DESC;


-- 3. ¿Qué consulta harías para obtener todas las ciudades de México con una población de más de 500,000? Tu consulta debe organizar el resultado por población en orden descendente.

SELECT ci.name,ci.population FROM cities ci
LEFT JOIN countries co ON ci.country_id = co.id
WHERE ci.population >	 500000 and co.name = 'Mexico' 
ORDER BY ci.population DESC;

-- 4. ¿Qué consulta ejecutarías para obtener todos los idiomas en cada país con un porcentaje superior al 89%? Tu consulta debe organizar el resultado por porcentaje en orden descendente.
SELECT co.name,lan.language, lan.percentage FROM  countries co
INNER JOIN languages lan ON co.id = lan.country_id 
WHERE lan.percentage > 89 
ORDER BY lan.percentage DESC;


-- 5. ¿Qué consulta haría para obtener todos los países con un área de superficie inferior a 501 y una población superior a 100,000?

SELECT name FROM countries 
WHERE surface_area < 501 AND population >100000;

-- 6. ¿Qué consulta harías para obtener países con solo Monarquía Constitucional con un capital superior a 200 y una esperanza de vida superior a 75 años?
SELECT name,code,region,government_form,capital,life_expectancy FROM countries
WHERE government_form = 'Constitutional Monarchy' AND capital > 200 AND life_expectancy > 75;

-- 7. ¿Qué consulta harías para obtener todas las ciudades de Argentina dentro del distrito de Buenos Aires y tener una población superior a 500,000? La consulta debe devolver el nombre del país, el nombre de la ciudad, el distrito y la población. 
SELECT co.name as Pais,ci.name as Ciudad,ci.district,ci.population FROM cities ci
LEFT JOIN countries co ON ci.country_id = co.id
WHERE ci.district = 'Buenos Aires' AND ci.population > 500000;

-- 8. ¿Qué consulta harías para resumir el número de países en cada región? La consulta debe mostrar el nombre de la región y el número de países. Además, la consulta debe organizar el resultado por el número de países en orden descendente.

SELECT region, COUNT(*) AS numero_de_paises
FROM countries
GROUP BY region
ORDER BY numero_de_paises DESC;