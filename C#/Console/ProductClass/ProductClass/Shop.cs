using System;

namespace Shop
{
    struct Article
    {
        public Article() {
            {
                _Id++;
                Id = _Id;
                Name = String.Empty;
                Value = 0;
                Type = null;
            }
        }
        private static int _Id { get; set; } = 0;
        public  int Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public ArticleTypes? Type { get; set; }
    }
    struct Client
    {
        public string Name{ get; set; }
        public string Surname{ get; set; }
        public string Patronymic { get; set; }
        public string Address { get; set; }
        public long PhoneNumber { get; set; }
        public int CountOfAllOrders { get; set; }
        public decimal CostOfAllOrders { get; set; }
        public ClientTypes? Type { get; set; }

    }
    struct RequestItem
    {
        public Article Item { get; set; }
        public int CountOfItem { get; set; }
        public string ToString(RequestItem item)
        {
            if (Item.Name != null) {
                return $"Item Name:{Item} Count of item:{CountOfItem}";
            }
            else { return "NULL"; }
        }

    }
    struct Request
    {
       public Request()
        {
            Id++;
            OrderId = Id;
            Client = new();
            RequestDate = DateTime.Now;
            OrdersCost = 0;
            _AllReguestedItmes = null;
            Type = null;
        }
        private static int Id { get; set; } = 0;
        public static int OrderId { get; set; }
        public Client Client { get; set; }
        public DateTime RequestDate { get; set; }
        public decimal OrdersCost { get; private  set; }
        private RequestItem[]? _AllReguestedItmes;
        public RequestItem[] AllReguestedItmes 
        {
            get
            {
                if(this._AllReguestedItmes == null)
                {
                    Console.WriteLine("Вы забыли инициализзировать переменную и хотели получить ее значение :( ");
                    throw new ArgumentNullException();
                }
                return this._AllReguestedItmes;
            }
            set
            {
                _AllReguestedItmes = value;
                if (_AllReguestedItmes != null)
                {
                    foreach (RequestItem item in _AllReguestedItmes)
                    {
                        OrdersCost += item.Item.Value;
                    }
                }
            }
        }
        PayTypes? Type { get; set; }

    }
    enum ArticleTypes
    {
        ConsumersGoods,
        CapitalGoods,
        DigitalGoods,
        VirtualGoods,
        VeblenGoods,
        Commodities,
        UnsoughtGoods,
        ComplementaryGoods,
        SuperiorGoods,
        ConsumerDiscretionary,
        SubsituteGoods,
        DurableGoods,
        SearchGoods,
        ExpirienceGoods,
        PerfectSubstitutes,
        FashionGoods,
        NecessityGoods,
        FastMovingConsumersGoods,
        MeritGoods,
        KnowledgeProducts,
        IntangibleGoods,
        FinishedGoods,
        InferiorGoods,
        PublicGoods,
        CommonResources,
        ConvenienceGoods,
    }
    enum ClientTypes
    {
        ClientWithPersonalConnections,
        RichClient,
        EfficientClient,
        UrgentClient,
        ClientWithNegativeExperience,
        ClientWithPositiveExperience,
        TrendyClients,
        ClientConcernedAboutSecurity,
        ClientWhoWorkOnCommittees,
        IndecisiveClients

    }
    enum PayTypes
    {
        InCash,
        PaymentSystem

    }
}