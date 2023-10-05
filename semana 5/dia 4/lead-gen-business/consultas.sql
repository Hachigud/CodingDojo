-- 1 ¿Qué consulta ejecutaría para obtener los ingresos totales para marzo de 2012?

SELECT  SUM(bi.amount)as Total, MONTHNAME(charged_datetime) as Mes 
FROM clients cl
INNER JOIN billing bi ON cl.client_id =  bi.client_id
WHERE bi.charged_datetime >= '2012/03/01' AND bi.charged_datetime <='2012/03/31'
ORDER BY Total DESC;

-- 2 ¿Qué consulta ejecutaría para obtener los ingresos totales recaudados del cliente con una identificación de 2?
SELECT  SUM(bi.amount)as Total ,CONCAT(cl.first_name,' ', cl.last_name) as Full_Name
FROM clients cl
INNER JOIN billing bi ON cl.client_id =  bi.client_id
WHERE cl.client_id = 2;

-- 3 Qué consulta ejecutaría para obtener todos los sitios que posee client = 10?
SELECT si.domain_name,CONCAT(cl.first_name,' ', cl.last_name) as Full_Name
FROM sites si
INNER JOIN clients cl ON cl.client_id = si.client_id 
WHERE cl.client_id = 10;

-- 4 ¿Qué consulta ejecutaría para obtener el número total de sitios creados por mes por año para el cliente con una identificación de 1? ¿Qué pasa con el cliente = 20?
SELECT  si.client_id, COUNT(si.domain_name) AS total, MONTHNAME(si.created_datetime) as Mes, YEAR(si.created_datetime) as Año
FROM sites si
WHERE si.client_id = 1 
GROUP BY Mes,Año;

SELECT  si.client_id, COUNT(si.domain_name) AS total, MONTHNAME(si.created_datetime) as Mes, YEAR(si.created_datetime) as Año
FROM sites si
WHERE si.client_id = 20
GROUP BY Mes,Año;

-- 5  ¿Qué consulta ejecutaría para obtener el número total de clientes potenciales generados para cada uno de los sitios entre el 1 de enero de 2011 y el 15 de febrero de 2011?

SELECT  si.domain_name, si.created_datetime, COUNT(le.leads_id) as Total_Clientes
FROM sites si
INNER JOIN leads le ON le.site_id = si.site_id
WHERE  le.registered_datetime >= '2011/01/01' AND le.registered_datetime <= '2011/02/15'
GROUP BY created_datetime;

-- 6  ¿Qué consulta ejecutaría para obtener una lista de nombres de clientes y el número total de clientes potenciales que hemos generado para cada uno de nuestros clientes entre el 1 de enero de 2011 y el 31 de diciembre de 2011?

SELECT CONCAT(cl.first_name,' ', cl.last_name) as Full_Name, COUNT(le.leads_id) as Total_Clientes
FROM sites si
INNER JOIN leads le ON le.site_id = si.site_id
INNER JOIN clients cl ON  cl.client_id = si.client_id
WHERE  le.registered_datetime >= '2011/01/01' AND le.registered_datetime <= '2011/12/30'
GROUP BY Full_Name
ORDER BY Total_Clientes DESC;

-- 7  ¿Qué consulta ejecutaría para obtener una lista de nombres de clientes y el número total de clientes potenciales que hemos generado para cada cliente cada mes entre los meses 1 y 6 del año 2011?
SELECT CONCAT(cl.first_name,' ', cl.last_name) as Full_Name, COUNT(le.leads_id) as Total_Leads, MONTHNAME(le.registered_datetime) as Mes
FROM clients cl
INNER JOIN sites si ON  cl.client_id = si.client_id
INNER JOIN leads le ON le.site_id = si.site_id
WHERE  le.registered_datetime >= '2011/01/01' AND le.registered_datetime <= '2011/06/30'  
GROUP BY Full_Name,Mes;


-- 8 . ¿Qué consulta ejecutaría para obtener una lista de nombres de clientes y el número total de clientes potenciales que hemos generado para cada uno de los sitios de nuestros clientes entre el 1 de enero de 2011 y el 31 de diciembre de 2011? Solicite esta consulta por ID de cliente. Presente una segunda consulta que muestre todos los clientes, los nombres del sitio y el número total de clientes potenciales generados en cada sitio en todo momento.

SELECT CONCAT(cl.first_name,' ', cl.last_name) as Full_Name, si.domain_name, COUNT(le.leads_id) as Total_Leads, le.registered_datetime
FROM clients cl
INNER JOIN sites si ON  cl.client_id = si.client_id
INNER JOIN leads le ON le.site_id = si.site_id
WHERE  le.registered_datetime >= '2011/01/01' AND le.registered_datetime <= '2011/12/31'  
GROUP BY si.domain_name;

SELECT CONCAT(cl.first_name,' ', cl.last_name) as Full_Name, si.domain_name, COUNT(le.leads_id) as Total_Leads
FROM clients cl
INNER JOIN sites si ON  cl.client_id = si.client_id
INNER JOIN leads le ON le.site_id = si.site_id
GROUP BY si.domain_name
ORDER BY Full_Name,Total_Leads DESC;

-- 9. Escriba una sola consulta que recupere los ingresos totales recaudados de cada cliente para cada mes del año. Pídalo por ID de cliente.
SELECT CONCAT(cl.first_name,' ', cl.last_name) as Full_Name, SUM(bi.amount) as Total, MONTHNAME(charged_datetime) as Mes, YEAR(charged_datetime) as Año
FROM clients cl
INNER JOIN billing bi ON cl.client_id =  bi.client_id
GROUP BY cl.client_id,Mes,Año
ORDER BY Full_Name,Mes,Año;

-- 10 Escriba una sola consulta que recupere todos los sitios que posee cada cliente. Agrupe los resultados para que cada fila muestre un nuevo cliente. Se volverá más claro cuando agregue un nuevo campo llamado 'sitios' que tiene todos los sitios que posee el cliente. (SUGERENCIA: use GROUP_CONCAT)
SELECT CONCAT(cl.first_name,' ', cl.last_name) as Full_Name, GROUP_CONCAT(si.domain_name) as Dominios
FROM sites si
INNER JOIN clients cl ON cl.client_id = si.client_id 
GROUP BY Full_Name;