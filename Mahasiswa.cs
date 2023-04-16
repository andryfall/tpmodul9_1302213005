namespace tpmodul9_1302213005
{
    public class Mahasiswa
    {
        public string Nama { get; set; }
        public int NIM { get; set; }
        public Mahasiswa(string nama, int nim)
        {
            this.Nama = nama;
            this.NIM = nim;
        }
    }
}
