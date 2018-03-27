import pyodbc

def Connect():     
    cnxn = pyodbc.connect("Driver={SQL Server Native Client 11.0};"
                      "Server=DESKTOP-R111LIA\SQLEXPRESS;"
                      "Database=Chat;"
                      "Trusted_Connection=yes;")
    cursor = cnxn.cursor()
    return cursor

def SignIn(cursor, email, password):
    query = 'exec SignIn \''+email+'\', \''+password+'\''
    return DBWork (cursor, query)  

def DBWork (cursor, query):
    try:       
        cursor.execute(query)       
        return 1
    except Exception:
        #cursor.close()
        return 0


