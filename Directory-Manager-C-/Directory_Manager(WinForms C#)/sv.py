from flask import Flask, render_templates

def serv():
  app = Flask(__name__);

  @app.route("/") 
  def open_html():
    return render_templates("index.html");

def main():
  print("Your server is in localhost:8000")
  app.run(debug=True, port=8000)

if __name__ == "__main__":
  main()
