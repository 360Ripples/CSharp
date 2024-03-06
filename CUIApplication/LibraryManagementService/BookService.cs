﻿using LibraryManagementBo.LibraryBo;
using LibraryManagementDao.LibraryException;
using LibraryManagementVo;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementService
{
    public class BookService
    {
        ResponseObject res = new ResponseObject();
        BookBo bo = new BookBo();



        public ResponseObject SaveBook(BookVo vo)
        {

            try
            {

                bool flag = bo.InsertBook(vo);//false
                Log.Information("Adding a Book {Vo}", vo);
                if (flag)
                {
                    Log.Information("Adding a Book {Flag}", vo.id);
                    res.SetSuccessMessage("Book Added Successfully");
                }
                else
                {
                    res.SetFailureMessage("Failed to insert the Record.Please Contact Admin..");
                }
            }
            catch (BookManagementException e)
            {
                Log.Error(e, "Error when Adding a Book {Vo}", vo.id);


                res.SetFailureMessage(e.Message);
            }
            // Log.Information(res);
            return res;//book added suucessfully
        }
        public ResponseObject GetBookById(int Id)
        {
            BookVo vo;
            try
            {
                vo = bo.GetBook(Id);
                Log.Information("Book Id {Id} fetched Successuly.", Id);
                if (vo.id > 0)
                {
                    res.SetVo(vo);
                }
                else
                {
                    res.SetFailureMessage("Failed to Fetch the record.");
                }
            }
            catch (BookNotFoundException e)
            {
                Log.Error(e, "Error when fetching Book details..");
                res.SetFailureMessage("Failed to Fetch the record.");
            }
            return res;
        }
        public ResponseObject GetAllBooks()
        {
            List<BookVo> list = new List<BookVo>();
            try
            {
                list = bo.GetBooks();
                Log.Information("Books{BookList} fetched Successuly.", list);
                res.SetBookVoList(list);
            }
            catch (BookNotFoundException e)
            {
                Log.Error(e, "Error when fetching Book details..");
                res.SetFailureMessage("Failed to Fetch the record.");
            }
            return res;
        }
    }
}