﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MusicTahp.Data;
using System;
using System.Linq;
namespace MusicTahp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MusicTahpContext(
            serviceProvider.GetRequiredService<
            DbContextOptions<MusicTahpContext>>()))
            {
                // Kiểm tra thông tin cuốn sách đã tồn tại hay chưa
                if (context.Music.Any())
                {
                    return; // Không thêm nếu cuốn sách đã tồn tại trong DB
                }
                context.Music.AddRange(
                new Music
                {
                    TenCaKhuc = "Dừng chờ anh nữa",
                    CaSi = "Đăng Phúc",
                    TheLoai = "Nhạc Trẻ",
                    NgayBan = DateTime.Parse("2021-8-3"),
                    Gia = 18.58M,
                    DiaChi = "Tuy Hòa",
                    TrangThai = "Tốt"
                },
                new Music
                {
                    TenCaKhuc = "Ngỡ như giấc mơ",
                    CaSi = "Chu Duyên ",
                    TheLoai = "Nhạc trẻ",
                    NgayBan = DateTime.Parse("2021-8-3"),
                    Gia = 10.58M,
                    DiaChi = "Tuy Hòa",
                    TrangThai = "Tốt"

                }
                ); ;
                context.SaveChanges();//lưu dữ liệu
            }
        }
    }
}

