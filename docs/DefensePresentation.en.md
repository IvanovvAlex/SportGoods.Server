# SportGoods Defense Presentation

This file provides a practical presentation structure for defending the SportGoods project. It is intended to be used together with the main project documentation and can be converted directly into a slide deck.

## Recommended Duration

- Total presentation time: 8 to 10 minutes
- Live demo: 2 to 3 minutes
- Questions and answers: 2 to 4 minutes

## Slide-by-Slide Structure

### Slide 1. Project Title and Team

**What to show**

- Project name: SportGoods
- Team members and roles
- Short subtitle: online store for sports goods

**What to say**

- Introduce the project as a web-based e-commerce system with customer and administrator functionality.
- State that the solution is split into two repositories, frontend and backend, to keep responsibilities clear.

### Slide 2. Problem and Motivation

**What to show**

- Short problem statement
- Target users: visitors, registered customers, administrators

**What to say**

- Explain that a physical store or weak catalog does not offer efficient filtering, saved products, account-based ordering, or operational visibility.
- State that SportGoods solves this by structuring the catalog and the ordering workflow end to end.

### Slide 3. Implemented Scope

**What to show**

- Public storefront features
- Customer features
- Admin features

**What to say**

- Mention browsing, filtering, product details, registration, login, cart, checkout, order history, wishlist, reviews, profile management, and GDPR actions.
- Mention the administrative overview, low-stock visibility, product management, category management, user management, and order status changes.

### Slide 4. System Architecture

**What to show**

- The high-level architecture diagram from the documentation

**What to say**

- Explain the client-server model.
- State that the React frontend communicates with an ASP.NET Core REST API.
- Explain that the API delegates business logic to domain services and persists data through Entity Framework Core and PostgreSQL.

### Slide 5. Backend Structure

**What to show**

- The backend project split: API, Domain, Data, Common, Core

**What to say**

- Explain why the backend is layered instead of placing all logic inside controllers.
- Mention examples such as `AuthService`, `OrderService`, `ProductService`, and the repository layer.

### Slide 6. Database Model and Core Domain Decision

**What to show**

- The E-R diagram
- Highlight the `Order` and `OrderItem` entities

**What to say**

- Explain the main entities: users, products, categories, images, reviews, wishlist, orders.
- Highlight the important design decision that an order with status `Created` acts as the active cart.
- Explain why `OrderItem` stores a transactional snapshot of title, price, and image.

### Slide 7. Main Workflow

**What to show**

- Checkout sequence diagram or order status state diagram

**What to say**

- Walk through the flow from selecting a product to completing checkout.
- Mention stock validation, status transition, quantity reduction, and confirmation logging.
- Emphasize that the same aggregate moves from cart state to operational order lifecycle.

### Slide 8. Technologies and Engineering Choices

**What to show**

- Backend technologies
- Frontend technologies
- Database and deployment technologies

**What to say**

- Explain why React, TypeScript, Vite, ASP.NET Core, EF Core, PostgreSQL, Docker, and JWT authentication were chosen.
- Mention that the choices were made for maintainability, readability, and suitability for the project scope.

### Slide 9. Quality, Security, and Testing

**What to show**

- Authentication and authorization summary
- Testing summary
- GDPR-related actions

**What to say**

- Mention password hashing, JWT authentication, refresh tokens, admin role checks, and exception middleware.
- Mention that the backend currently contains 113 automated tests.
- State honestly that frontend automated tests are still a future improvement area.

### Slide 10. Live Demo

**What to show**

- A short guided path through the running application

**What to say**

- Suggested demo path: home page, product details, add to cart, checkout confirmation, orders page, then admin overview and order management.
- Keep the demo short and deterministic. Avoid relying on unstable or optional flows during the defense.

### Slide 11. Limitations and Future Work

**What to show**

- A short list of current limitations
- A short list of realistic next steps

**What to say**

- State that payment is still a demo flow, email delivery is console-based, frontend tests are not yet implemented, and CI/CD is not included in the repository.
- Explain that the next steps would be real payment and email integrations, frontend tests, and deployment automation.

### Slide 12. Conclusion

**What to show**

- Final summary
- Closing statement

**What to say**

- Conclude that SportGoods is a complete academic project with a clear architecture, real business workflows, automated backend testing, and realistic documentation.
- End with a short invitation for questions.

## Suggested Live Demo Route

1. Open the home page and briefly show categories and best sellers.
2. Open one product and point out the description, images, rating, and stock information.
3. Add the product to the cart and continue to checkout.
4. Show the checkout form with payment and delivery method selection.
5. Open the orders page and explain the customer-facing order state.
6. Switch to the admin workspace and show low-stock products, overview metrics, and order status management.

## Questions to Prepare For

- Why was `Order` reused as the cart instead of creating a separate cart table?
- Why was PostgreSQL chosen as the database?
- Why is the backend split into multiple projects?
- How is administrator access protected?
- What is the difference between the current demo payment flow and a production payment integration?
- What would be the first improvement after the academic submission?
