import pymysql
db = pymysql.connect("77.222.63.58","kgpd02","Wzfuv175","samarityanin", charset='utf8')
f = open('data.txt', 'w')

cursor = db.cursor()
sql = "SELECT * from " + "id8381923;"
cursor.execute(sql)
results = cursor.fetchall()
print(results)
f.write(str(results))
db.close
f.close()
