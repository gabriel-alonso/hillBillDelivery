using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Menu()
        {
            return View();
        }
        public ActionResult Montar()
        {
            return View();
        }
        public ActionResult single0()
        {
            Acompanhamentos A = new Acompanhamentos();

            if (Request.HttpMethod.Equals("POST"))
            {
                A.nome = Request.Form["nome"].ToString();
                A.descricao = Request.Form["descricao"].ToString();
                A.quantidade = Convert.ToInt32(Request.Form["quantidade"].ToString());
                A.preco = Convert.ToDouble(Request.Form["preco"].ToString());
                A.ultima_atualizacao = Convert.ToDateTime(Request.Form["ultima_atualizacao"].ToString());

                if(A.Salvar() == true)
                {
                    ViewBag.mensagem = "Cadastrado com sucesso!";
                }
            }
            ViewBag.Extras = A.Listar();
            return View();
        }
        public ActionResult Single1()
        {
            Acompanhamentos A = new Acompanhamentos();

            if (Request.HttpMethod.Equals("POST"))
            {
                A.nome = Request.Form["nome"].ToString();
                A.descricao = Request.Form["descricao"].ToString();
                A.quantidade = Convert.ToInt32(Request.Form["quantidade"].ToString());
                A.preco = Convert.ToDouble(Request.Form["preco"].ToString());
                A.ultima_atualizacao = Convert.ToDateTime(Request.Form["ultima_atualizacao"].ToString());

                if (A.Salvar() == true)
                {
                    ViewBag.mensagem = "Cadastrado com sucesso!";
                }
            }
            ViewBag.Extras = A.Listar();
            return View();
        }
        public ActionResult Single2()
        {
            Acompanhamentos A = new Acompanhamentos();

            if (Request.HttpMethod.Equals("POST"))
            {
                A.nome = Request.Form["nome"].ToString();
                A.descricao = Request.Form["descricao"].ToString();
                A.quantidade = Convert.ToInt32(Request.Form["quantidade"].ToString());
                A.preco = Convert.ToDouble(Request.Form["preco"].ToString());
                A.ultima_atualizacao = Convert.ToDateTime(Request.Form["ultima_atualizacao"].ToString());

                if (A.Salvar() == true)
                {
                    ViewBag.mensagem = "Cadastrado com sucesso!";
                }
            }
            ViewBag.Extras = A.Listar();
            return View();
        }
        public ActionResult Single3()
        {
            Acompanhamentos A = new Acompanhamentos();

            if (Request.HttpMethod.Equals("POST"))
            {
                A.nome = Request.Form["nome"].ToString();
                A.descricao = Request.Form["descricao"].ToString();
                A.quantidade = Convert.ToInt32(Request.Form["quantidade"].ToString());
                A.preco = Convert.ToDouble(Request.Form["preco"].ToString());
                A.ultima_atualizacao = Convert.ToDateTime(Request.Form["ultima_atualizacao"].ToString());

                if (A.Salvar() == true)
                {
                    ViewBag.mensagem = "Cadastrado com sucesso!";
                }
            }
            ViewBag.Extras = A.Listar();
            return View();
        }
        public ActionResult Single4()
        {
            Acompanhamentos A = new Acompanhamentos();

            if (Request.HttpMethod.Equals("POST"))
            {
                A.nome = Request.Form["nome"].ToString();
                A.descricao = Request.Form["descricao"].ToString();
                A.quantidade = Convert.ToInt32(Request.Form["quantidade"].ToString());
                A.preco = Convert.ToDouble(Request.Form["preco"].ToString());
                A.ultima_atualizacao = Convert.ToDateTime(Request.Form["ultima_atualizacao"].ToString());

                if (A.Salvar() == true)
                {
                    ViewBag.mensagem = "Cadastrado com sucesso!";
                }
            }
            ViewBag.Extras = A.Listar();
            return View();
        }
        public ActionResult Single5()
        {
            Acompanhamentos A = new Acompanhamentos();

            if (Request.HttpMethod.Equals("POST"))
            {
                A.nome = Request.Form["nome"].ToString();
                A.descricao = Request.Form["descricao"].ToString();
                A.quantidade = Convert.ToInt32(Request.Form["quantidade"].ToString());
                A.preco = Convert.ToDouble(Request.Form["preco"].ToString());
                A.ultima_atualizacao = Convert.ToDateTime(Request.Form["ultima_atualizacao"].ToString());

                if (A.Salvar() == true)
                {
                    ViewBag.mensagem = "Cadastrado com sucesso!";
                }
            }
            ViewBag.Extras = A.Listar();
            return View();
        }
        public ActionResult Single6()
        {
            Acompanhamentos A = new Acompanhamentos();

            if (Request.HttpMethod.Equals("POST"))
            {
                A.nome = Request.Form["nome"].ToString();
                A.descricao = Request.Form["descricao"].ToString();
                A.quantidade = Convert.ToInt32(Request.Form["quantidade"].ToString());
                A.preco = Convert.ToDouble(Request.Form["preco"].ToString());
                A.ultima_atualizacao = Convert.ToDateTime(Request.Form["ultima_atualizacao"].ToString());

                if (A.Salvar() == true)
                {
                    ViewBag.mensagem = "Cadastrado com sucesso!";
                }
            }
            ViewBag.Extras = A.Listar();
            return View();
        }
        public ActionResult Single7()
        {
            Acompanhamentos A = new Acompanhamentos();

            if (Request.HttpMethod.Equals("POST"))
            {
                A.nome = Request.Form["nome"].ToString();
                A.descricao = Request.Form["descricao"].ToString();
                A.quantidade = Convert.ToInt32(Request.Form["quantidade"].ToString());
                A.preco = Convert.ToDouble(Request.Form["preco"].ToString());
                A.ultima_atualizacao = Convert.ToDateTime(Request.Form["ultima_atualizacao"].ToString());

                if (A.Salvar() == true)
                {
                    ViewBag.mensagem = "Cadastrado com sucesso!";
                }
            }
            ViewBag.Extras = A.Listar();
            return View();
        }
        public ActionResult Single8()
        {
            Acompanhamentos A = new Acompanhamentos();

            if (Request.HttpMethod.Equals("POST"))
            {
                A.nome = Request.Form["nome"].ToString();
                A.descricao = Request.Form["descricao"].ToString();
                A.quantidade = Convert.ToInt32(Request.Form["quantidade"].ToString());
                A.preco = Convert.ToDouble(Request.Form["preco"].ToString());
                A.ultima_atualizacao = Convert.ToDateTime(Request.Form["ultima_atualizacao"].ToString());

                if (A.Salvar() == true)
                {
                    ViewBag.mensagem = "Cadastrado com sucesso!";
                }
            }
            ViewBag.Extras = A.Listar();
            return View();
        }
        public ActionResult Single9()
        {
            Acompanhamentos A = new Acompanhamentos();

            if (Request.HttpMethod.Equals("POST"))
            {
                A.nome = Request.Form["nome"].ToString();
                A.descricao = Request.Form["descricao"].ToString();
                A.quantidade = Convert.ToInt32(Request.Form["quantidade"].ToString());
                A.preco = Convert.ToDouble(Request.Form["preco"].ToString());
                A.ultima_atualizacao = Convert.ToDateTime(Request.Form["ultima_atualizacao"].ToString());

                if (A.Salvar() == true)
                {
                    ViewBag.mensagem = "Cadastrado com sucesso!";
                }
            }
            ViewBag.Extras = A.Listar();
            return View();
        }
        public ActionResult Single10()
        {
            Acompanhamentos A = new Acompanhamentos();

            if (Request.HttpMethod.Equals("POST"))
            {
                A.nome = Request.Form["nome"].ToString();
                A.descricao = Request.Form["descricao"].ToString();
                A.quantidade = Convert.ToInt32(Request.Form["quantidade"].ToString());
                A.preco = Convert.ToDouble(Request.Form["preco"].ToString());
                A.ultima_atualizacao = Convert.ToDateTime(Request.Form["ultima_atualizacao"].ToString());

                if (A.Salvar() == true)
                {
                    ViewBag.mensagem = "Cadastrado com sucesso!";
                }
            }
            ViewBag.Extras = A.Listar();
            return View();
        }
        public ActionResult Single11()
        {
            Acompanhamentos A = new Acompanhamentos();

            if (Request.HttpMethod.Equals("POST"))
            {
                A.nome = Request.Form["nome"].ToString();
                A.descricao = Request.Form["descricao"].ToString();
                A.quantidade = Convert.ToInt32(Request.Form["quantidade"].ToString());
                A.preco = Convert.ToDouble(Request.Form["preco"].ToString());
                A.ultima_atualizacao = Convert.ToDateTime(Request.Form["ultima_atualizacao"].ToString());

                if (A.Salvar() == true)
                {
                    ViewBag.mensagem = "Cadastrado com sucesso!";
                }
            }
            ViewBag.Extras = A.Listar();
            return View();
        }

    }
}