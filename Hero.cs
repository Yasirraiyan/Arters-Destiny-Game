public class Hero
{
    public string name;
    public int health=10;
    public int strength;
    public int power;
    public bool attack=false;
    public int x;
    public int y;
    public int z;
    public int rank;
    public int life=5;
    public Hero(string name, int health, int strength, int power, int x, int y, int z,int rank) 
    { 
        this.name = name;
        this.health = health; 
        this.strength = strength; 
        this.power = power; 
        this.x = x; 
        this.y = y; 
        this.z = z;
        this.rank=rank;
    }
    public (int, int) GetPosition2D(int x, int y) 
    { 
        if (x > 0 && y > 0) 
        { 
            Console.WriteLine("The point is in the 1st quadrant."); 
            
        }
        else if (x < 0 && y > 0) 
        { 
            Console.WriteLine("The point is in the 2nd quadrant.");
        }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("The point is in the 3rd quadrant."); 
                
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("The point is in the 4th quadrant.");
                } 
                else if (x == 0 && y == 0)
                { 
                    Console.WriteLine("The point is at the origin.");
                } 
                else if (x == 0) 
                { 
                    if (y > 0) 
                    { 
                        Console.WriteLine("The point is on the positive Y axis."); 
                        
                    } 
                    else if (y < 0)
                    { 
                        Console.WriteLine("The point is on the negative Y axis.");
                        } 
                    
                }
                else if (y == 0)
                { if (x > 0)
                {
                    Console.WriteLine("The point is on the positive X axis."); 
                    
                } 
                else if (x < 0)
                { 
                    Console.WriteLine("The point is on the negative X axis.");
                    
                } 
                    
                } 
                else
                
                {
                    Console.WriteLine("Unknown coordinate combination.");
                    } 
                    return (x, y);
                    }
                    public (int, int, int) GetPosition3D(int x, int y, int z)
                    {
                        if (x > 0 && y > 0 && z > 0)
                        { 
                            Console.WriteLine("The point is in the 1st octant.");
                            }
                            else if (x < 0 && y > 0 && z > 0) 
                            {
                                Console.WriteLine("The point is in the 2nd octant."); 
                                
                            } 
                            else if (x < 0 && y < 0 && z > 0)
                            { 
                                Console.WriteLine("The point is in the 3rd octant."); 
                                
                            }
                            else if (x > 0 && y < 0 && z > 0)
                            { 
                                Console.WriteLine("The point is in the 4th octant."); 
                                
                            }
                            else if (x > 0 && y > 0 && z < 0)
                            { 
                                Console.WriteLine("The point is in the 5th octant.");
                                }
                                else if (x < 0 && y > 0 && z < 0)
                                { 
                                    Console.WriteLine("The point is in the 6th octant."); 
                                    
                                } 
                                else if (x < 0 && y < 0 && z < 0) 
                                { 
                                    Console.WriteLine("The point is in the 7th octant.");
                                    } 
                                    else if (x > 0 && y < 0 && z < 0) 
                                    { 
                                        Console.WriteLine("The point is in the 8th octant.");
                                        } 
                                        else if (x == 0 && y == 0 && z == 0)
                                        {
                                            Console.WriteLine("The point is at the origin.");
                                            } 
                                            else if (x == 0) 
                                            { 
                                                if (y == 0) 
                                                {
                                                    if (z > 0)
                                                    { 
                                                        Console.WriteLine("The point is on the positive Z axis."); 
                                                        
                                                    } 
                                                    else if (z < 0)
                                                    { 
                                                        Console.WriteLine("The point is on the negative Z axis.");
                                                        }
                                                        } 
                                                        else if (y > 0)
                                                        { 
                                                            if (z == 0)
                                                            {
                                                                Console.WriteLine("The point is on the positive Y axis.");
                                                                } 
                                                                else
                                                                { 
                                                                    Console.WriteLine("The point is on the YZ plane."); 
                                                                    
                                                                } 
                                                            
                                                        } 
                                                        else if (y < 0)
                                                        { 
                                                            if (z == 0)
                                                            { 
                                                                Console.WriteLine("The point is on the negative Y axis."); 
                                                                
                                                            } 
                                                            else 
                                                            { 
                                                                Console.WriteLine("The point is on the YZ plane."); 
                                                                
                                                            } 
                                                            
                                                        }
                                                        }
                                                        else if (y == 0) 
                                                        { 
                                                            if (x == 0) 
                                                            { 
                                                                if (z > 0)
                                                                { 
                                                                    Console.WriteLine("The point is on the positive Z axis."); 
                                                                    
                                                                } 
                                                                else if (z < 0)
                                                                { 
                                                                    Console.WriteLine("The point is on the negative Z axis."); 
                                                                    
                                                                } 
                                                                
                                                            } 
                                                            else if (x > 0) 
                                                            { 
                                                                if (z == 0)
                                                                { 
                                                                    Console.WriteLine("The point is on the positive X axis."); 
                                                                    
                                                                } 
                                                                else 
                                                                {
                                                                    Console.WriteLine("The point is on the XZ plane."); 
                                                                    
                                                                } 
                                                                
                                                            } 
                                                            else if (x < 0)
                                                            { 
                                                                if (z == 0)
                                                                { 
                                                                    Console.WriteLine("The point is on the negative X axis.");
                                                                    } 
                                                                    else
                                                                    { 
                                                                        Console.WriteLine("The point is on the XZ plane.");
                                                                        } 
                                                                
                                                            } 
                                                            
                                                        } 
                                                        else if (z == 0) 
                                                        { 
                                                            if (x == 0)
                                                            { 
                                                                if (y > 0) 
                                                                { 
                                                                    Console.WriteLine("The point is on the positive Y axis."); 
                                                                    
                                                                }
                                                                else if (y < 0)
                                                                {
                                                                    Console.WriteLine("The point is on the negative Y axis."); 
                                                                    
                                                                } 
                                                                
                                                            } 
                                                            else if (x > 0) 
                                                            {
                                                                if (y == 0)
                                                                {
                                                                    Console.WriteLine("The point is on the positive X axis.");
                                                                    } 
                                                                    else
                                                                    { 
                                                                        Console.WriteLine("The point is on the XY plane."); 
                                                                        
                                                                    } 
                                                                
                                                            } 
                                                            else if (x < 0)
                                                            { 
                                                                if (y == 0)
                                                                { 
                                                                    Console.WriteLine("The point is on the negative X axis.");
                                                                    } 
                                                                    else 
                                                                    { 
                                                                        Console.WriteLine("The point is on the XY plane."); 
                                                                        
                                                                    }
                                                                    } 
                                                            
                                                        }
                                                        else
                                                        { 
                                                            Console.WriteLine("Unknown coordinate combination."); 
                                                            
                                                        }
                                                        return (x, y, z);
                                                        }
                    public string getname()
                    {
                        return name;
                    }
                    public int getpower()
                    {
                       return power;
                    }
                    public (int, string, string) DeterminePositionRankAndType(int position, string rank, string soldierType)
                    { 
                        if (position >= 1 && position <= 10) 
                        { 
                            Console.WriteLine($"The soldier {name} is in the frontline.");
                            } 
                            else if (position >= 11 && position <= 20)
                            { 
                                Console.WriteLine($"The soldier {name} is in the second line."); 
                                
                            } 
                            else if (position >= 21 && position <= 30)
                            { 
                                Console.WriteLine($"The soldier {name} is in the third line."); 
                                
                            } 
                            else if (position > 30) 
                            { 
                                Console.WriteLine($"The soldier {name} is in the reserve.");
                                } 
                                else 
                                { 
                                    Console.WriteLine($"The position of the soldier {name} is unknown."); 
                                    
                                }
                                if (rank == "General") 
                                { 
                                    Console.WriteLine($"The soldier {name} has the highest rank: {rank}.");
                                    } 
                                    else if (rank == "Colonel")
                                    { 
                                        Console.WriteLine($"The soldier {name} has a high rank: {rank}.");
                                        } 
                                        else if (rank == "Captain")
                                        { 
                                            Console.WriteLine($"The soldier {name} has a mid-level rank: {rank}."); 
                                            
                                        }
                                        else if (rank == "Lieutenant") 
                                        { 
                                            Console.WriteLine($"The soldier {name} has a lower rank: {rank}.");
                                            } 
                                            else if (rank == "Sergeant") 
                                            { 
                                                Console.WriteLine($"The soldier {name} has the lowest rank: {rank}.");
                                                } 
                                                else 
                                                { 
                                                    Console.WriteLine($"The rank of the soldier {name} is unknown."); } if (soldierType == "Infantry") { Console.WriteLine($"The soldier {name} is an Infantry soldier."); } else if (soldierType == "Cavalry") { Console.WriteLine($"The soldier {name} is a Cavalry soldier."); } else if (soldierType == "Archer") { Console.WriteLine($"The soldier {name} is an Archer soldier."); } else if (soldierType == "Mage") { Console.WriteLine($"The soldier {name} is a Mage soldier."); 
                                                        
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine($"The type of the soldier {name} is unknown.");
                                                        }
                                                        return (position, rank, soldierType);
                                                        }
                                                        public string DetermineSoldierType(int strength)
                                                        { 
                                                            if (strength >= 80)
                                                            { 
                                                                return "Elite";
                                                                }
                                                                else if (strength >= 6 )
                                                                { 
                                                                    return "Veteran";
                                                                    } else if (strength >= 40)
                                                                    {
                                                                        return "Regular";
                                                                        }
                                                                        else if (strength >= 20)
                                                                        { 
                                                                            return "Rookie";
                                                                            } 
                                                                            else
                                                                            {
                                                                                return "Trainee";
                                                                                } 
                                                            
                                                        } 
                                                        public (int, string, string) DeterminePositionRankAndType(int position, string rank, int strength)
                                                        { 
                                                            if (position >= 1 && position <= 10) 
                                                            {
                                                                Console.WriteLine($"The soldier {name} is in the frontline.");
                                                                } 
                                                                else if (position >= 11 && position <= 20)
                                                                { 
                                                                    Console.WriteLine($"The soldier {name} is in the second line.");
                                                                    } 
                                                                    else if (position >= 21 && position <= 30) 
                                                                    { 
                                                                        Console.WriteLine($"The soldier {name} is in the third line.");
                                                                        } 
                                                                        else if (position > 30) 
                                                                        { 
                                                                            Console.WriteLine($"The soldier {name} is in the reserve."); 
                                                                            
                                                                        } 
                                                                        else
                                                                        { 
                                                                            Console.WriteLine($"The position of the soldier {name} is unknown.");
                                                                            } 
                                                                            if (rank == "General") 
                                                                            {
                                                                                Console.WriteLine($"The soldier {name} has the highest rank: {rank}."); 
                                                                                
                                                                            } 
                                                                            else if (rank == "Colonel")
                                                                            { 
                                                                                
                                                                                Console.WriteLine($"The soldier {name} has a high rank: {rank}."); 
                                                                                
                                                                            } 
                                                                            else if (rank == "Captain")
                                                                            { 
                                                                                Console.WriteLine($"The soldier {name} has a mid-level rank: {rank}.");
                                                                                } 
                                                                                else if (rank == "Lieutenant")
                                                                                {
                                                                                    Console.WriteLine($"The soldier {name} has a lower rank: {rank}.");
                                                                                    } 
                                                                                    else if (rank == "Sergeant")
                                                                                    { 
                                                                                        Console.WriteLine($"The soldier {name} has the lowest rank: {rank}."); 
                                                                                        
                                                                                    } 
                                                                                    else
                                                                                    { 
                                                                                        Console.WriteLine($"The rank of the soldier {name} is unknown.");
                                                                                        } 
                                                                                        Console.WriteLine($"The soldier {name} is classified as: {soldierType}");
                                                                                        return (position, rank, soldierType);
                                                        }
                                                            
                                                        }
                                                        public void survive()
                                                        {
                                                            while(!attack&&life>0)
                                                            {
                                                                life=life/5;
                                                            }
                                                            if(life==0)
                                                            {
                                                                Console.WriteLine("Dead")
                                                            }
                                                        }
                                                        public void AccessRank()
                                                        { 
                                                            Console.WriteLine($"Rank: {rank}");
                                                            if 
                                                            { 
                                                                Console.WriteLine("Soldier is a high-ranking officer.");
                                                                } 
                                                                else 
                                                                {
                                                                    Console.WriteLine("Soldier is a low-ranking officer."); 
                                                                    
                                                                }
                                                                } 
                                                                public void AccessLife()
                                                                { 
                                                                    Console.WriteLinene($"Life: {life}");
                                                                    while (life > 0)
                                                                    { 
                                                                        Console.WriteLine($"Soldier {name} is fighting with {life} lives remaining.");
                                                                        life--;
                                                                        } 
                                                                        if (life == 0)
                                                                        {
                                                                            Console.WriteLine("Soldier has no lives remaining.")
                                                                            ; 
                                                                            
                                                                        } 
                                                                    
                                                                }
