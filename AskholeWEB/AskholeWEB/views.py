"""
Routes and views for the flask application.
"""

from datetime import datetime
from flask import render_template, request
from AskholeWEB import app

@app.route('/')
@app.route('/home')
def home():
    """Renders the home page."""
    return render_template(
        'index.html',
        title='Home Page',
        year=datetime.now().year,
    )

@app.route('/contact')
def contact():
    """Renders the contact page."""
    return render_template(
        'contact.html',
        title='Contact',
        year=datetime.now().year,
        message='Your contact page.'
    )

@app.route('/about')
def about():
    """Renders the about page."""
    return render_template(
        'about.html',
        title='About',
        year=datetime.now().year,
        message='Your application description page.'
    )
@app.route('/signin', methods = ['GET', 'POST'])
def signin():
    """Renders the about page."""
    if request.method == 'POST':
        email = request.form['emailinput']
        password = request.form['passwordinput']
        return render_template('signinsuccessful.html',title='MainForm', em = email, pas = password)
    elif request.method == 'GET':
        return render_template('signin.html',title='Sign in')
@app.route('/signup', methods = ['GET', 'POST'])
def signup():
    """Renders the about page."""
    if request.method == 'POST':
        username = request.form['inputUsername']
        email = request.form['inputEmail']
        password = request.form['inputPassword']
        return render_template('signinsuccessful.html',title='MainForm', em = email, pas = password)
    elif request.method == 'GET':
        return render_template('signup.html',title='Sign up')
